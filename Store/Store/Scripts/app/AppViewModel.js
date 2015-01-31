var app = new AppViewModel();

function AppViewModel() {

    // #region initialize ===========================================

    self = this;

    self.initialize = function () {

        initProductList();
        pluginsInitialize();

        function initProductList() {
            $.ajax({
                url: '/api/Products/',
                type: 'GET',
                dataType: 'json',
                success: function (data) {
                    var item = "";
                    $.each(data, function () {
                        item += '<li><a><img data-id=' + this.Id + ' src=' + this.Images[0].Url + ' /></a><a data-id=' +
                            this.Id + '>' + this.Name + '</a></li>';
                    });
                    $(".category-list").append('<ul>' + item + '</ul>');
                },
                error: function () {
                    alert("error");
                }
            });
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

};

$(document).ready(function () {
    $(".category-list").on("click", function (e) {
        if ($(e.target).is('.category-list img,a')) {
            GetProduct($(e.target).data('id'));
        }
    });

    function GetProduct(id) {
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
    };

    function SetDetailProduct(product) {
        var viewData = {
            data: product
        };
        $.ajax({
            url: '/Home/DetailProduct',
            type: 'POST',
            data: viewData,
            success: function (data) {
                $('.category-list').addClass('passive');
                $('.content').append(data);
            },
            error: function () {
                alert("error");
            }
        });
    };
});
