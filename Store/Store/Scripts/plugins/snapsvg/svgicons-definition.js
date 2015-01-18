(function () {

    // initialize svg icons

    var menusearchOptions = {
        size: { w: 16, h: 16 },
        speed: 200,

        title: "Очистить",
        shortcut: "Delete",

        toggleEv: 'keyup',
        toggleFn: function () {
            debugger;
            svgIcon.prototype.toggle(this, $(this).val().length > 0);
        },

        actionEv: 'click',
        actionFn: function () {
            debugger;
            $(this).relField().val('');
        }
    };

    svgIconIni($('[data-icon="menusearch"]'), svgIconConfig, menusearchOptions);
    svgIconIni($('[data-icon="logo"]'), svgIconConfig, { size: { w: 227, h: 33 } });
    svgIconIni($('[data-icon="toggleMenuItem"]'), svgIconConfig, { size: { w: 16, h: 16 }, speed: 300 });
    svgIconIni($('[data-icon="toggleMenu"]'), svgIconConfig, { toggleEv: 'mouseover', size: { w: 32, h: 32 }, speed: 300 });
    
    function svgIconIni(elts, config, options) {
        $(elts).each(function (index, el) {
            new svgIcon(el, config, options);
        });
    };

})();