/*
 * Created by: Kassym Gapur
 * Created: 02.02.2015
 */

var app = new AppViewModel();

function AppViewModel() {

    // #region initialize ===========================================

    self = this;

    self.initialize = function () {

        initProductList();
        pluginsInitialize();

        function initProductList() {
            if ($('.category-list').length > 0) {
                $('.filter-menu').removeClass('passive').addClass("fadeInUp");
                $.ajax({
                    url: '/api/Products/',
                    type: 'GET',
                    dataType: 'json',
                    success: function (data) {
                        buildProduct(data);
                        $(".category-list ul").addClass('fadeIn');
                    },
                    error: function () {
                        alert("error");
                    }
                });
            }
        }

        function pluginsInitialize() {
        };
    };

    // #endregion initialize ========================================

    // #region menu toggle ==========================================

    self.menuIsOpen = ko.observable(true);

    self.toggleMenu = function () {
        $(".left-aside").toggleClass("toggled");
        self.menuIsOpen(!self.menuIsOpen());
    };

    // #endregion menu toggle =======================================

    // #region manage product =======================================

    self.GetProduct = function (itSelf, event) {
        if ($(event.target).is('.category-list img,a')) {
            var id = $(event.target).data('id');
            $.ajax({
                url: '/api/Products/' + id,
                type: 'GET',
                success: function (data) {
                    SetDetailProduct(data);
                },
                error: function () {
                    alert("error");
                }
            });
        }

        function SetDetailProduct(product) {
            var viewData = {
                data: product
            };
            $.ajax({
                url: '/Home/DetailProduct/',
                type: 'POST',
                data: viewData,
                success: function (data) {
                    $('.category-list').addClass('passive');
                    $('.content').append(data);
                    generateProductInfo(product);
                },
                error: function () {
                    alert("error");
                }
            });
        };
    };

    // #endregion manage product =======================================

    // #region callback product =======================================

    self.callBack = function () {
        $('.detail-info').addClass('fadeOutRight');
        setTimeout(function () {
            $('.category-list').removeClass('passive');
            $('.detail-info').remove();
        }, 700);
    };

    // #endregion callback product =======================================

    // #region filter product =======================================

    self.filterProduct = function (itSelf, event) {
        var type = $(event.target).data('type');
        $(".category-list ul").addClass('fadeOut');
        $.ajax({
            url: '/Products/' + type + '/FilterProducts',
            type: 'GET',
            success: function (data) {
                buildProduct(data);
                $(".category-list ul").removeClass('fadeOut').addClass("fadeIn");
            },
            error: function () {
                alert("error");
            }
        });
    };

    // #endregion filter product =======================================

    // #region build element product =======================================

    function buildProduct(data) {
        $(".category-list ul").empty();
        $.each(data, function () {
            var item = $('<li><img data-bind=click:GetProduct data-id=' + this.Id + ' src=' + this.Images[0].Url +
                ' /><a data-bind=click:GetProduct data-id=' + this.Id + '>' + this.Name + '</a></li>');
            $(".category-list ul").append(item);
            ko.applyBindings(app, item[0]);
        });
    };

    // #endregion build element product =======================================
};

