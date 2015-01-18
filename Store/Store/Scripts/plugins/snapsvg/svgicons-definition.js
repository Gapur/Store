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
    svgIconIni($('[data-icon="mail"]'), svgIconConfig, { size: { w: 16, h: 16 } });
    svgIconIni($('[data-icon="mark_warning"]'), svgIconConfig, { size: { w: 16, h: 20 }, speed: 300 });
    svgIconIni($('[data-icon="task_icon"]'), svgIconConfig, { toggleEv: 'click', size: { w: 16, h: 16 }, speed: 300 });
    svgIconIni($('[data-icon="user_icon"]'), svgIconConfig, { size: { w: 16, h: 16 } });
    svgIconIni($('[data-icon="toggleMenuItem"]'), svgIconConfig, { size: { w: 16, h: 16 }, speed: 300 });
    svgIconIni($('[data-icon="toggleMenu"]'), svgIconConfig, { toggleEv: 'mouseover', size: { w: 32, h: 32 }, speed: 300 });
    svgIconIni($('[data-icon="is_expand_all_items_icon"]'), svgIconConfig, { toggleEv: 'click', size: { w: 16, h: 16 } });
    svgIconIni($('[data-icon="is_block_select_items_icon"]'), svgIconConfig, { toggleEv: 'click', size: { w: 16, h: 16 } });
    svgIconIni($('[data-icon="is_multipul_select_items_icon"]'), svgIconConfig, { toggleEv: 'click', size: { w: 16, h: 16 } });
    svgIconIni($('[data-icon="breadcrums_button"]'), svgIconConfig, { toggleEv: 'click', size: { w: 32, h: 32 }, speed: 300 });
    
    function svgIconIni(elts, config, options) {
        $(elts).each(function (index, el) {
            new svgIcon(el, config, options);
        });
    };

    // #region Demo

    // initialize all

    //    [].slice.call(document.querySelectorAll('.si-icons-default > .si-icon')).forEach(function (el) {
    //        var svgicon = new svgIcon(el, svgIconConfig);
    //    });

    //    new svgIcon(document.querySelector('.si-icons-easing .si-icon-nav-left-arrow'), svgIconConfig, { easing: mina.backin });
    //    new svgIcon(document.querySelector('.si-icons-easing .si-icon-hamburger'), svgIconConfig, { easing: mina.backin });
    //    new svgIcon(document.querySelector('.si-icons-easing .si-icon-plus'), svgIconConfig, { easing: mina.backin });
    //    new svgIcon(document.querySelector('.si-icons-easing .si-icon-volume'), svgIconConfig, { easing: mina.backin });
    //    new svgIcon(document.querySelector('.si-icons-easing .si-icon-hourglass'), svgIconConfig, { easing: mina.backin });
    //    new svgIcon(document.querySelector('.si-icons-easing .si-icon-equalizer'), svgIconConfig, { easing: mina.backin });
    //    new svgIcon(document.querySelector('.si-icons-easing .si-icon-hamburger-cross'), svgIconConfig, { easing: mina.elastic, speed: 600 });
    //    new svgIcon(document.querySelector('.si-icons-easing .si-icon-trash'), svgIconConfig, { easing: mina.elastic, speed: 600 });
    //    new svgIcon(document.querySelector('.si-icons-easing .si-icon-clock'), svgIconConfig, { easing: mina.elastic, speed: 600 });
    //    new svgIcon(document.querySelector('.si-icons-easing .si-icon-maximize'), svgIconConfig, { easing: mina.elastic, speed: 600 });
    //    new svgIcon(document.querySelector('.si-icons-easing .si-icon-contract'), svgIconConfig, { easing: mina.elastic, speed: 600 });
    //    new svgIcon(document.querySelector('.si-icons-easing .si-icon-glass-empty'), svgIconConfig, { easing: mina.elastic, speed: 600 });

    //    new svgIcon(document.querySelector('.si-icon-clock'), svgIconConfig, { easing: mina.backin, evtoggle: 'mouseover', size: { w: 128, h: 128 } });
    //    new svgIcon(document.querySelector('[data-icon-name="test"]'), svgIconConfig, { evtoggle: 'mouseover', size: { w: 128, h: 128 } });
    //    new svgIcon(document.querySelector('.si-icons-hover .si-icon-hamburger'), svgIconConfig, { easing: mina.backin, evtoggle: 'mouseover', size: { w: 128, h: 128 } });
    //    new svgIcon(document.querySelector('.si-icons-hover .si-icon-flag'), svgIconConfig, { easing: mina.backin, evtoggle: 'mouseover', size: { w: 128, h: 128 } });
    //    new svgIcon(document.querySelector('.si-icons-hover .si-icon-zoom'), svgIconConfig, { easing: mina.backin, evtoggle: 'mouseover', size: { w: 128, h: 128 } });
    //    new svgIcon(document.querySelector('.si-icons-hover .si-icon-maximize'), svgIconConfig, { easing: mina.backin, evtoggle: 'mouseover', size: { w: 128, h: 128 } });
    //    new svgIcon(document.querySelector('.si-icons-hover .si-icon-equalizer'), svgIconConfig, { easing: mina.backin, evtoggle: 'mouseover', size: { w: 128, h: 128 } });
    // #endregion Demo
})();