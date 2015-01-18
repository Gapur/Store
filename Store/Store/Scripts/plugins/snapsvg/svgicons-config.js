var svgIconConfig = {
    logo: { url: '/Content/icons/svg/logo.svg' },

    user_icon: { url: '/Content/icons/svg/user_icon.svg' },

    mark_warning: {
        url: '/Content/icons/svg/mark_warning.svg',
        animation: [
        {
            el: 'path:nth-child(1)',
            animProperties: {
                from: { val: '{"transform" : "rotate(0 8 11)"}' },
                to: { val: '{"transform" : "rotate(120 8 11)"}' }
            }
        }
        ]
    },

    task_icon: {
        url: '/Content/icons/svg/task_icon.svg',
        animation: [
        {
            el: 'path:nth-child(2)',
            animProperties: {
                from: { val: '{"path" : "M15 4.5 l -4 0"}' },
                to: { val: '{"path" : "M15 4.5 l -14 0"}' }
            }
        },
        {
            el: 'path:nth-child(5)',
            animProperties: {
                from: { val: '{"path" : "M15 8.5 l -9 0"}' },
                to: { val: '{"path" : "M15 8.5 l -3 0"}' }
            }
        },
         {
             el: 'path:nth-child(6)',
             animProperties: {
                 from: { val: '{"path" : "M15 12.5 l -6 0"}' },
                 to: { val: '{"path" : "M15 12.5 l -12 0"}' }
             }
         }
        ]
    },

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

    breadcrums_button: {
        url: '/Content/icons/svg/breadcrums_button_close.svg',
        animation: [
        {
            el: 'path:nth-child(3)',
            animProperties: {
                from: { val: '{"path" : "M 7 15 l 4 0"}' },
                to: { val: '{"path" : "M 13 9 l 4 0"}' }
            }
        },
        {
            el: 'path:nth-child(4)',
            animProperties: {
                from: { val: '{"path" : "M 19 15 l 4 0"}' },
                to: { val: '{"path" : "M 13 21 l 4 0"}' }
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

    toggleMenuBtnToggle: function (g) {
        Snap(g).select('path:nth-child(1)').animate({ path: app.menuIsOpen() ? 'm 4,16 12,-12 0,5 -9.2,9.2 -2.6,-2.6 z' : 'm 16,4 12,12 -2.6,2.6 -9.2,-9.2 0,-5 z' }, 300, mina.linear);
        Snap(g).select('path:nth-child(2)').animate({ path: app.menuIsOpen() ? 'm 6,14 0,0 0,4 0,0 0,-4 z' : 'm 26,14 0,0 0,4 0,0 0,4 z' }, 300, mina.linear);
        Snap(g).select('path:nth-child(3)').animate({ path: app.menuIsOpen() ? 'm 6.8,14 9.2,9.2 0,5 -12,-12 2.6,-2.6 z' : 'm 15.4,23.4 9.2,-9.2 2.6,2.6 -12,12 0,-5 z' }, 300, mina.linear);
    },

    is_expand_all_items_icon: {
        url: '/Content/icons/svg/is_expand_all_items_icon.svg',
        animation: [
            {
                el: 'path:nth-child(2)',
                animProperties: {
                    from: { val: '{"path" : "m 3,4 0,9 1,0 0,-9 -1,0z"}' },
                    to: { val: '{"path" : "m 3,4 0,5 1,0 0,-5 -1,0z"}' }
                }
            },
            {
                el: 'path:nth-child(3)',
                animProperties: {
                    from: { val: '{"path" : "m 3,5 7,0 0,1 -7,0 0,-1z"}' },
                    to: { val: '{"path" : "m 3,9 7,0 0,1 -7,0 0,-1z"}' }
                }
            },
    		{
    		    el: 'path:nth-child(4)',
    		    animProperties: {
    		        from: { val: '{"path" : "m 10,6 a 1 1 0 1 1 1 0 z"}' },
    		        to: { val: '{"path" : "m 10,10 a 1 1 0 1 1 1 0 z"}' }
    		    }
    		},
    		{
    		    el: 'path:nth-child(7)',
    		    animProperties: {
    		        from: { val: '{"path" : "m 3,13 7,0 0,1 -7,0 0,-1z"}' },
    		        to: { val: '{"path" : "m 3,9 7,0 0,1 -7,0 0,-1z"}' }
    		    }
    		},
    		{
    		    el: 'path:nth-child(8)',
    		    animProperties: {
    		        from: { val: '{"path" : "m 10,14 a 1 1 0 1 1 1 0 z"}' },
    		        to: { val: '{"path" : "m 10,10 a 1 1 0 1 1 1 0 z"}' }
    		    }
    		}
        ]
    },

    is_block_select_items_icon: {
        url: '/Content/icons/svg/is_block_select_items_icon.svg',
        animation: [
            {
                el: 'path:nth-child(1)',
                animProperties: {
                    from: { val: '{"fill" : "white"}' },
                    to: { val: '{"fill" : "#A5A5A5"}' }
                }
            },
            {
                el: 'path:nth-child(3)',
                animProperties: {
                    from: { val: '{"fill" : "white"}' },
                    to: { val: '{"fill" : "#A5A5A5"}' }
                }
            },
            {
                el: 'path:nth-child(5)',
                animProperties: {
                    from: { val: '{"fill" : "white"}' },
                    to: { val: '{"fill" : "#A5A5A5"}' }
                }
            }
        ]
    },

    is_multipul_select_items_icon: {
        url: '/Content/icons/svg/is_multipul_select_items_icon.svg',
        animation: [
            {
                el: 'path:nth-child(1)',
                animProperties: {
                    from: { val: '{"path" : "m 2,7 12,0 0,2 -12,0 0,-2 z"}' },
                    to: { val: '{"path" : "m 2,3 12,0 0,2 -12,0 0,-2 z"}' }
                }
            },
            {
                el: 'path:nth-child(3)',
                animProperties: {
                    from: { val: '{"path" : "m 2,7 12,0 0,2 -12,0 0,-2 z"}' },
                    to: { val: '{"path" : "m 2,11 12,0 0,2 -12,0 0,-2 z"}' }
                }
            }
        ]
    },
};


//ieAnimationDetach(svgIconConfig, "toggleMenu");
//
//function ieAnimationDetach(svgIconConfig, anim) {
//    if (Browser.browser == 'Explorer') {
//        svgIconConfig[anim].animation = "";
//    }
//};

//    path="" dur="3s" rotate="auto" repeatCount="indefinite"
//	contract : { 
//		url : 'svg/contract.svg',
//		animation : [
//			{ 
//				el : 'rect:nth-child(2)', 
//				animProperties : { 
//					from : { val : '{"transform" : "t0 0"}', after : '{ "opacity" : 0 }' }, 
//					to : { val : '{"transform" : "t-5 -5"}', before : '{ "opacity" : 1 }' }
//				} 
//			},
//			{ 
//				el : 'rect:nth-child(3)', 
//				animProperties : { 
//					from : { val : '{"transform" : "t0 0"}', after : '{ "opacity" : 0 }' }, 
//					to : { val : '{"transform" : "t-10 -10"}', before : '{ "opacity" : 1 }' }
//				} 
//			}
//		]
//	},
//	maximize : { 
//		url : 'svg/maximize.svg',
//		animation : [
//			{ 
//				el : 'path:nth-child(1)', 
//				animProperties : { 
//					from : { val : '{"transform" : "t0 0"}' }, 
//					to : { val : '{"transform" : "t-5 -5"}' }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(2)', 
//				animProperties : { 
//					from : { val : '{"transform" : "t0 0"}' }, 
//					to : { val : '{"transform" : "t5 -5"}' }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(3)', 
//				animProperties : { 
//					from : { val : '{"transform" : "t0 0"}' }, 
//					to : { val : '{"transform" : "t-5 5"}' }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(4)', 
//				animProperties : { 
//					from : { val : '{"transform" : "t0 0"}' }, 
//					to : { val : '{"transform" : "t5 5"}' }
//				} 
//			}
//		]
//	},
//	maximizeRotate : { 
//		url : 'svg/maximize.svg',
//		animation : [
//			{ 
//				el : 'path:nth-child(1)', 
//				animProperties : { 
//					from : { val : '{"transform" : "r0 16 16 t0 0"}' }, 
//					to : { val : '{"transform" : "r180 16 16 t-5 -5"}' }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(2)', 
//				animProperties : { 
//					from : { val : '{"transform" : "r0 48 16 t0 0"}' }, 
//					to : { val : '{"transform" : "r-180 48 16 t5 -5"}' }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(3)', 
//				animProperties : { 
//					from : { val : '{"transform" : "r0 16 48 t0 0"}' }, 
//					to : { val : '{"transform" : "r-180 16 48 t-5 5"}' }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(4)', 
//				animProperties : { 
//					from : { val : '{"transform" : "r0 48 48 t0 0"}' }, 
//					to : { val : '{"transform" : "r180 48 48 t5 5"}' }
//				} 
//			}
//		]
//	},
//	volume : {
//		url : 'svg/volume.svg',
//		animation : [
//			{ 
//				el : 'path:nth-child(1)', 
//				animProperties : { 
//					from : { val : '{"transform" : "t-10 0 s0 32 32"}' }, 
//					to : { val : '{"transform" : "t0 0 s1 32 32", "opacity" : 1}', before : '{"transform" : "t-10 0 s0 32 32"}', delayFactor : .5 }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(2)', 
//				animProperties : { 
//					from : { val : '{"transform" : "t-10 0 s0 32 32"}', delayFactor : .25 }, 
//					to : { val : '{"transform" : "t0 0 s1 32 32", "opacity" : 1}', before : '{"transform" : "t-10 0 s0 32 32"}', delayFactor : .25 }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(3)', 
//				animProperties : { 
//					from : { val : '{"transform" : "t-10 0 s0 32 32"}', delayFactor : .5 }, 
//					to : { val : '{"transform" : "t0 0 s1 32 32", "opacity" : 1}', before : '{"transform" : "t-10 0 s0 32 32"}' }
//				} 
//			}
//		]
//	},
//	plus : { 
//		url : 'svg/plus.svg',
//		animation : [
//			{ 
//				el : 'path:nth-child(1)', 
//				animProperties : { 
//					from : { val : '{"transform" : "r0 32 32", "opacity" : 1}' }, 
//					to : { val : '{"transform" : "r180 32 32", "opacity" : 0}' }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(2)', 
//				animProperties : { 
//					from : { val : '{"transform" : "r0 32 32"}' }, 
//					to : { val : '{"transform" : "r180 32 32"}' }
//				} 
//			}
//		]
//	},
//	plusCross : { 
//		url : 'svg/plus.svg',
//		animation : [
//			{ 
//				el : 'path:nth-child(1)', 
//				animProperties : { 
//					from : { val : '{"transform" : "r0 32 32"}' }, 
//					to : { val : '{"transform" : "r45 32 32"}' }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(2)', 
//				animProperties : { 
//					from : { val : '{"transform" : "r0 32 32"}' }, 
//					to : { val : '{"transform" : "r45 32 32"}' }
//				} 
//			}
//		]
//	},
//	hamburger : {
//		url : 'svg/hamburger.svg',
//		animation : [
//			{ 
//				el : 'path:nth-child(1)', 
//				animProperties : { 
//					from : { val : '{"path" : "m 5.0916789,20.818994 53.8166421,0"}' }, 
//					to : { val : '{"path" : "m 5.091679,9.771104 53.816642,0"}' }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(3)', 
//				animProperties : { 
//					from : { val : '{"path" : "m 5.0916788,42.95698 53.8166422,0"}' }, 
//					to : { val : '{"path" : "m 5.0916789,54.00487 53.8166421,0"}' }
//				} 
//			}
//		]
//	},
//	hamburgerCross : {
//		url : 'svg/hamburger.svg',
//		animation : [
//			{ 
//				el : 'path:nth-child(1)', 
//				animProperties : { 
//					from : { val : '{"path" : "m 5.0916789,20.818994 53.8166421,0"}' }, 
//					to : { val : '{"path" : "M 12.972944,50.936147 51.027056,12.882035"}' }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(2)', 
//				animProperties : { 
//					from : { val : '{"transform" : "s1 1", "opacity" : 1}', before : '{"transform" : "s0 0"}' }, 
//					to : { val : '{"opacity" : 0}' }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(3)', 
//				animProperties : { 
//					from : { val : '{"path" : "m 5.0916788,42.95698 53.8166422,0"}' }, 
//					to : { val : '{"path" : "M 12.972944,12.882035 51.027056,50.936147"}' }
//				} 
//			}
//		]
//	},
//	navLeftArrow : {
//		url : 'svg/nav-left-arrow.svg',
//		animation : [
//			{ 
//				el : 'path', 
//				animProperties : { 
//					from : { val : '{"path" : "M 48.592939,9.792208 15.407062,31.887987 48.592939,54.025974"}' }, 
//					to : { val : '{"path" : "M 15.407062,9.792208 48.592939,31.887987 15.407062,54.025974"}' }
//				} 
//			}
//		]
//	},
//	navUpArrow : {
//		url : 'svg/nav-up-arrow.svg',
//		animation : [
//			{ 
//				el : 'path', 
//				animProperties : { 
//					from : { val : '{"path" : "M 9.8831175,48.502029 31.978896,15.316152 54.116883,48.502029"}' }, 
//					to : { val : '{"path" : "M 9.8831175,15.316152 31.978896,48.502029 54.116883,15.316152"}' }
//				} 
//			}
//		]
//	},
//	rightArrow : {
//		url : 'svg/right-arrow.svg',
//		animation : [
//			{ 
//				el : 'path', 
//				animProperties : { 
//					from : { val : '{"path" : "M 34.419061,13.24425 57.580939,32.017897 34.419061,50.75575"}' }, 
//					to : { val : '{"path" : "M 31.580939,13.24425 8.419061,32.017897 31.580939,50.75575"}' }
//				} 
//			}
//		]
//	},
//	downArrow : {
//		url : 'svg/down-arrow.svg',
//		animation : [
//			{ 
//				el : 'path', 
//				animProperties : { 
//					from : { val : '{"path" : "M 14.083963,33.258774 32.85761,56.420652 51.595463,33.258774"}' }, 
//					to : { val : '{"path" : "M 14.083963,30.420652 32.85761,7.258774 51.595463,30.420652"}' }
//				} 
//			}
//		]
//	},
//	smiley : {
//		url : 'svg/smiley.svg',
//		animation : [
//			{ 
//				el : 'path', 
//				animProperties : { 
//					from : { val : '{"path" : "m 19.380224,39.901132 c 0,0 4.860771,5.28501 12.770151,5.28501 7.909379,0 12.770152,-5.28501 12.770152,-5.28501"}' }, 
//					to : { val : '{"path" : "m 19.380224,45.186142 c 0,0 4.860771,-5.28501 12.770151,-5.28501 7.909379,0 12.770152,5.28501 12.770152,5.28501"}' }
//				} 
//			}
//		]
//	},
//	play : {
//		url : 'svg/play.svg',
//		animation : [
//			{ 
//				el : 'path', 
//				animProperties : { 
//					from : { val : '{"path" : "M 18.741071,52 31.30178,42.531655 45.258928,31.887987 18.741071,12 z"}' }, 
//					to : { val : '{"path" : "m 12.5,52 39,0 0,-40 -39,0 z"}' }
//				} 
//			}
//		]
//	},
//	mail : {
//		url : 'svg/mail.svg',
//		animation : [
//			{ 
//				el : 'path', 
//				animProperties : { 
//					from : { val : '{"path" : "m 61.693118,24.434001 -59.386236,0 29.692524,19.897984 z"}' }, 
//					to : { val : '{"path" : "m 61.693118,24.434001 -59.386236,0 29.692524,-19.7269617 z"}' }
//				} 
//			}
//		]
//	},
//	equalizer : {
//		url : 'svg/equalizer.svg',
//		animation : [
//			{ 
//				el : 'path:nth-child(1)', 
//				animProperties : { 
//					from : { val : '{"transform" : "t 0 0"}' }, 
//					to : { val : '{"transform" : "t 0 -30"}' }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(2)', 
//				animProperties : { 
//					from : { val : '{"transform" : "t 0 0"}' }, 
//					to : { val : '{"transform" : "t 0 35"}' }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(3)', 
//				animProperties : { 
//					from : { val : '{"transform" : "t 0 0"}' }, 
//					to : { val : '{"transform" : "t 0 -10"}' }
//				} 
//			}
//		]
//	},
//	glass : {
//		url : 'svg/glass.svg',
//		animation : [
//			{ 
//				el : 'path', 
//				animProperties : { 
//					from : { val : '{"path" : "m 16.778805,44 c 0,0 9.518312,-3.481153 13.221195,-2 10,4 17.153596,2 17.153596,2 L 45,54 20,54 z"}' }, 
//					to : { val : '{"path" : "M 13.183347,29 C 13.183347,29 25,31.439358 30,29 c 12.710171,-6.200932 20,0 20,0 l -5,25 -25,0 z"}' }
//				} 
//			}
//		]
//	},
//	hourglass : {
//		url : 'svg/hourglass.svg',
//		animation : [
//			{ 
//				el : 'path:nth-child(1)', 
//				animProperties : { 
//					from : { val : '{"transform" : "r 0 32 32"}' }, 
//					to : { val : '{"transform" : "r 180 32 32"}' }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(2)', 
//				animProperties : { 
//					from : { val : '{"transform" : "r 0 32 32"}', animAfter : '{"path" : "m 31,32 2,0 0,0 9,15 -20,0 9,-15 z"}' }, 
//					to : { val : '{"transform" : "r 180 32 32"}', animAfter : '{"path" : "m 22,17 20,0 -9,15 0,0 -2,0 0,0 z"}' }
//				} 
//			}
//		]
//	},
//	padlock : {
//		url : 'svg/padlock.svg',
//		animation : [
//			{ 
//				el : 'path', 
//				animProperties : { 
//					from : { val : '{"transform" : "t 0 0"}' }, 
//					to : { val : '{"transform" : "t 0 -11"}' }
//				} 
//			}
//		]
//	},
//	zoom : {
//		url : 'svg/zoom.svg',
//		animation : [
//			{ 
//				el : 'path:nth-child(1)', 
//				animProperties : { 
//					from : { val : '{"transform" : "s 1 1"}' }, 
//					to : { val : '{"transform" : "s 1.1 1.1"}' }
//				} 
//			},
//			{ 
//				el : 'path:nth-child(2)', 
//				animProperties : { 
//					from : { val : '{"transform" : "s 1 1", "stroke-width" : "1"}' }, 
//					to : { val : '{"transform" : "s 2 2", "stroke-width" : "2"}' }
//				} 
//			}
//		]
//	},
//	monitor : {
//		url : 'svg/monitor.svg',
//		animation : [
//			{ 
//				el : 'path', 
//				animProperties : { 
//					from : { val : '{"path" : "m 5,11.75 0,33.75 20.25,0 -6.75,6.75 27,0 -6.75,-6.75 20.25,0 0,-33.75 -54,0 z m 2.65625,2.875 48.6875,0 0,27.8125 -48.6875,0 0,-27.8125 z"}' }, 
//					to : { val : '{"path" : "m 21.875,16.8125 0,30.375 3.375,0 3.5,0 3.25,0 6.75,0 3.375,0 0,-30.375 -20.25,0 z m 3.375,3.375 13.5,0 0,20.25 -13.5,0 0,-20.25 z m 6.75,22.25 c 0.756641,0 1.375,0.618359 1.375,1.375 0,0.756641 -0.618359,1.375 -1.375,1.375 -0.756641,0 -1.375,-0.618359 -1.375,-1.375 0,-0.756641 0.618359,-1.375 1.375,-1.375 z"}' }
//				} 
//			}
//		]
//	},
//	flag : {
//		url : 'svg/flag.svg',
//		animation : [
//			{ 
//				el : 'path', 
//				animProperties : { 
//					from : { val : '{"path" : "m 11.75,11.75 c 0,0 10.229631,3.237883 20.25,0 10.020369,-3.2378833 20.25,0 20.25,0 l 0,27 c 0,0 -6.573223,-3.833185 -16.007359,0 -9.434136,3.833185 -24.492641,0 -24.492641,0 z"}' }, 
//					to : { val : '{"path" : "m 11.75,11.75 c 0,0 8.373476,-4.8054563 17.686738,0 9.313262,4.805456 22.813262,0 22.813262,0 l 0,27 c 0,0 -11.699747,4.363515 -22.724874,0 C 18.5,34.386485 11.75,38.75 11.75,38.75 z"}' }
//				} 
//			}
//		]
//	}
//};