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
                        item += '<li><a><img src=/Content/img/LG.jpg /></a><a>' + this.Name + '</a></li>';
                    });
                    $(".category-list").append("<ul>" + item + "</ul>");
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