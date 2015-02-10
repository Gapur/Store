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
                $('.preloader').removeClass('passive');
                $('.filter-menu').removeClass('passive').addClass("fadeInUp");
                $.ajax({
                    url: '/api/Products/',
                    type: 'GET',
                    dataType: 'json',
                    success: function (data) {
                        $('.preloader').addClass('passive');
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
            $('.datetimepicker').datetimepicker({
                pickTime: false,
                language: 'ru'
            });
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
                    $('.detail-info').remove();
                    $('.category-list').addClass('passive');
                    $('.content').append(data);
                },
                error: function () {
                    alert("error");
                }
            });
        };
    };

    // #endregion manage product =======================================

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

    // #region selected type product =======================================

    self.selectedItems = ko.observableArray(null);

    self.selectedItems.subscribe(function () {
        $('.optional').removeClass('passive');
        switch (self.selectedItems()[0]) {
            case "1":
                $('.notebook-scope').addClass('passive');
                $('.phone-scope').removeClass('passive');
                break;
            case "2":
                $('.phone-scope').addClass('passive');
                $('.notebook-scope').removeClass('passive');
                break;
            case "3":
                $('.optional').addClass('passive');
                break;
            default:
                $('.optional').addClass('passive');
                alert("Необходимо выбрать тип продукта");
                break;
        }
    });

    // #endregion selected type product =======================================

    // #region pay product =======================================

    self.payProduct = function () {
        alert("В магазин сходи");
    };

    // #endregion pay product ======================================= 

    // #region navbar-right ====================================

    self.toggleNavbarMenu = function (itSelf, event) {
        $('.dropdown-menu').toggleClass('open');
        $(document).click(function (e) {
            if (!$(e.target).is('.navbar-nav > li, .navbar-nav > li *'))
                $(".navbar-nav > li.dropdown ul").removeClass("open");
        });
    }

    // #endregion navbar-right ==================================

};

