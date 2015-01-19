var svgIconConfig = {
    logo: { url: '/Content/icons/svg/logo.svg' },

    user_icon: { url: '/Content/icons/svg/user_icon.svg' },

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

    toggleMenu:
    {
        url: '/Content/icons/svg/toggleMenu.svg',
        animation: [
            {
                el: 'path:nth-child(1)',
                animProperties: {
                    from: { val: '{"path" : "m 4,6 6,0 0,5 -6,0 0,-5 z"}' },
                    to: { val: '{"path" : "app.menuIsOpen() ? \'m 4,16 6,-4 5,0 -6,4 -5,0 z\' : \'m 7,4 5,0 6,4 -5,0 -6,-4 z\' "}' }
                }
            },
    		{
    		    el: 'path:nth-child(2)',
    		    animProperties: {
    		        from: { val: '{"path" : "m 14,6 6,0 0,5 -6,0 0,-5 z"}' },
    		        to: { val: '{"path" : "app.menuIsOpen() ? \'m 10,12 6,-4 5,0 -6,4 -5,0 z\' : \'m 13,8 5,0 6,4 -5,0 -6,-4 z\' "}' }
    		    }
    		},
    		{
    		    el: 'path:nth-child(3)',
    		    animProperties: {
    		        from: { val: '{"path" : "m 24,6 6,0 0,5 -6,0 0,-5 z"}' },
    		        to: { val: '{"path" : "app.menuIsOpen() ? \'m 16,8 6,-4 5,0 -6,4 -5,0 z\' : \'m 19,12 5,0 6,4 -5,0 -6,-4 z\' "}' }
    		    }
    		},
    		{
    		    el: 'path:nth-child(4)',
    		    animProperties: {
    		        from: { val: '{"path" : "m 4,14 6,0 0,5 -6,0 0,-5 z"}' },
    		        to: { val: '{"path" : "app.menuIsOpen() ? \'m 9,14 6,0 0,4 -6,0 0,-4 z\' : \'m 7,14 6,0 0,4 -6,0 0,-4 z\' "}' }
    		    }
    		},
    		{
    		    el: 'path:nth-child(5)',
    		    animProperties: {
    		        from: { val: '{"path" : "m 14,14 6,0 0,5 -6,0 0,-5 z"}' },
    		        to: { val: '{"path" : "app.menuIsOpen() ? \'m 15,14 6,0 0,4 -6,0 0,-4  z\' : \'m 13,14 6,0 0,4 -6,0 0,-4 z\' "}' }
    		    }
    		},
    		{
    		    el: 'path:nth-child(6)',
    		    animProperties: {
    		        from: { val: '{"path" : "m 24,14 6,0 0,5 -6,0 0,-5 z"}' },
    		        to: { val: '{"path" : "app.menuIsOpen() ? \'m 21,14 6,0 0,4 -6,0 0,-4  z\' : \'m 19,14 6,0 0,4 -6,0 0,-4 z\' "}' }
    		    }
    		},
    		{
    		    el: 'path:nth-child(7)',
    		    animProperties: {
    		        from: { val: '{"path" : "m 4,22 6,0 0,5 -6,0 0,-5 z"}' },
    		        to: { val: '{"path" : "app.menuIsOpen() ? \'m 4,16 6,4 5,0 -6,-4 -5,0 z\' : \'m 7,28 6,-4 5,0 -6,4 -5,0 z\' "}' }
    		    }
    		},
    		{
    		    el: 'path:nth-child(8)',
    		    animProperties: {
    		        from: { val: '{"path" : "m 14,22 6,0 0,5 -6,0 0,-5 z"}' },
    		        to: { val: '{"path" : "app.menuIsOpen() ? \'m 10,20 6,4 5,0 -6,-4 -5,0 z\' : \'m 13,24 6,-4 5,0 -6,4 -5,0 z\' "}' }
    		    }
    		},
    		{
    		    el: 'path:nth-child(9)',
    		    animProperties: {
    		        from: { val: '{"path" : "m 24,22 6,0 0,5 -6,0 0,-5 z"}' },
    		        to: { val: '{"path" : "app.menuIsOpen() ? \'m 16,24 6,4 5,0 -6,-4 -5,0 z\' : \'m 19,20 6,-4 5,0 -6,4 -5,0 z\' "}' }
    		    }
    		}
        ]
    },
};

