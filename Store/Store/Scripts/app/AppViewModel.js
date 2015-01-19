var app = new AppViewModel();

function AppViewModel() {

    // #region initialize ===========================================

    self = this;

    self.initialize = function () {

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