var svgIconConfig = {
    logo: { url: '/Content/icons/svg/logo.svg' },

    user_icon: { url: '/Content/icons/svg/user_icon.svg' },

    mail: {
        url: '/Content/icons/svg/mail.svg',
        animation: [
        {
            el: 'path:nth-child(3)',
            animProperties: {
                from: { val: '{"path" : "M 0.5 5.5 l 7.5 5.5 l 7.5 -5.5z"}' },
                to: { val: '{"path" : "M 0.5 5.5 l 7.5 -5.5 l 7.5 5.5z"}' }
            }
        }
        ]
    },

    menusearch: {
        url: '/Content/icons/svg/menu-search.svg',
        animation: [
            {
                el: 'path:nth-child(1)',
                animProperties: {
                    from: { val: '{"path" : "m 5.5,10.5 a 5 5 0 1 1 1 0 z m 2.5,-0.7 3.5,5.0 -1.5,0.7 -2.5,-5.5 z"}' },
                    to: { val: '{"path" : "m 2,3 1,-1 10,10 -1,1 -10,-10"}' }
                },

            },
            {
                el: 'path:nth-child(2)',
                animProperties: {
                    from: { val: '{"path" : "m 5.5,9.5 a 4 4 0 1 1 1 0 z", "fill": "#747474"}' },
                    to: { val: '{"path" : "m 12,2 1,1 -10,10 -1,-1 10,-10", "fill": "#fff"}' }
                }
            },
            {
                el: 'path:nth-child(3)',
                animProperties: {
                    from: { val: '{"opacity" : 1}' },
                    to: { val: '{"opacity" : 0}' }
                }
            }
        ]
    },

    toggleMenuItem:
    {
        url: '/Content/icons/svg/toggleMenuItem.svg',
        animation: [
            {
                el: 'path:nth-child(2)',
                animProperties: {
                    from: { val: '{"path" : "m 5,4 1,1 -4,4 -1,-1 4,-4 z"}' },
                    to: { val: '{"path" : "m 8,7 1,1 -4,4 -1,-1 4,-4 z"}' }
                },

            }
        ]
    },

    toggleMenu:
    {
        url: '/Content/icons/svg/toggleMenu.svg',
        animation: [
            {
                el: 'path:nth-child(1)',
                animProperties: {
                    from: { val: '{"path" : "m 4,6 24,0 0,4 -24,0 0,-4 z"}' },
                    to: { val: '{"path" : "app.menuIsOpen() ? \'m 4,16 12,-12 0,5 -9.2,9.2 -2.6,-2.6 z\' : \'m 16,4 12,12 -2.6,2.6 -9.2,-9.2 0,-5 z\' "}' }
                }
            },
    		{
    		    el: 'path:nth-child(2)',
    		    animProperties: {
    		        from: { val: '{"path" : "m 4,14 24,0 0,4 -24,0 0,-4 z"}' },
    		        to: { val: '{"path" : "app.menuIsOpen() ? \'m 6,14 0,0 0,4 0,0 0,-4 z\' : \'m 26,14 0,0 0,4 0,0 0,4 z\' "}' }
    		    }
    		},
    		{
    		    el: 'path:nth-child(3)',
    		    animProperties: {
    		        from: { val: '{"path" : "m 4,22 24,0 0,4 -24,0 0,-4 z"}' },
    		        to: { val: '{"path" : "app.menuIsOpen() ? \'m 6.8,14 9.2,9.2 0,5 -12,-12 2.6,-2.6 z\' : \'m 15.4,23.4 9.2,-9.2 2.6,2.6 -12,12 0,-5 z\' "}' }
    		    }
    		}
        ]
    },
};

