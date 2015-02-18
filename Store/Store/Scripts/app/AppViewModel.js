/*
 * Created by: Kassym Gapur
 * Created: 02.02.2015
 */

var app = new AppViewModel();

function AppViewModel() {

    // #region initialize ===========================================

    self = this;
    self.selectFile = ko.observable(null);

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
                        self.buildProduct(data);
                        $(".category-list ul").addClass('fadeIn');
                    },
                    error: function () {
                    }
                });
            }
        }

        function pluginsInitialize() {
            $('.datetimepicker').datetimepicker({
                pickTime: false,
                language: 'ru'
            });

            if ($("#fu-my-simple-upload").length > 0)
                fileUpload();

            if ($("#photo_container").length > 0)
                loadCarousel();
        };

        // #region file upload ==========================================

        function fileUpload() {
            $('#fu-my-simple-upload').fileupload({
                url: '/Home/UploadFile',
                dataType: 'json',
                add: function (e, data) {
                    jqXHRData = data
                },
                done: function (event, data) {
                    if (data.result.isUploaded) {
                        $("#tbx-file-path").val("No file chosen...");
                    }
                    else {

                    }
                    alert(data.result.message);
                },
                fail: function (event, data) {
                    if (data.files[0].error) {
                        alert(data.files[0].error);
                    }
                }
            });
        };

        // #endregion file upload ==========================================

        // #region load plugin carousel ==========================================

        function loadCarousel() {
            var carousel_images = [
                "/Content/icons/png/1.jpg",
                "/Content/icons/png/2.jpg",
                "/Content/icons/png/3.jpg",
                "/Content/icons/png/4.jpg",
                "/Content/icons/png/5.jpg",
                "/Content/icons/png/6.jpg",
                "/Content/icons/png/7.jpg",
                "/Content/icons/png/8.jpg"];

            $(window).load(function () {
                $("#photo_container").isc({
                    imgArray: carousel_images
                });
            });
        };

        // #endregion load plugin carousel ==========================================

    };

    // #endregion initialize ========================================

    // #region menu toggle ==========================================

    self.menuIsOpen = ko.observable(true);

    self.toggleMenu = function () {
        $(".left-aside").toggleClass("toggled");
        self.menuIsOpen(!self.menuIsOpen());
    };

    // #endregion menu toggle =======================================

    // #region file upload ==========================================

    var jqXHRData;
    self.selectFile.subscribe(function () {
        $("#tbx-file-path").val(self.selectFile());
    });

    self.startUpload = function () {
        if (jqXHRData) {
            jqXHRData.submit();
        }
        return false;
    };

    // #endregion file upload ==========================================

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
                self.buildProduct(data);
                $(".category-list ul").removeClass('fadeOut').addClass("fadeIn");
            },
            error: function () {
            }
        });
    };

    // #endregion filter product =======================================

    // #region build element product =======================================

    self.buildProduct = function (data) {
        $(".category-list ul").empty();
        $.each(data, function () {
            var item = $('<li><img data-bind=click:GetProduct data-id=' + this.Id + ' src=' + this.Images.Url +
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

    // #region navbar-right ====================================

    self.toggleNavbarMenu = function (itSelf, event) {
        $('.dropdown-menu').toggleClass('open');
        $(document).click(function (e) {
            if (!$(e.target).is('.navbar-nav > li, .navbar-nav > li *'))
                $(".navbar-nav > li.dropdown ul").removeClass("open");
        });
    }

    // #endregion navbar-right ==================================

    // #region pay product =======================================

    self.payProduct = function () {
        alert("В магазин сходи");
    };

    // #endregion pay product ======================================= 

    // #region remove cart =======================================

    self.removeCart = function (itSelf, event) {
        var viewData = {
            productId: $(event.target).data('productid')
        };
        $.ajax({
            url: '/Cart/RemoveFromCart/',
            type: 'POST',
            data: viewData,
            success: function (data) {
                if (data == "True") {
                    alert("Продукт удален из корзины");
                    $(event.target).parent().parent().remove();
                }
                else alert("Во время операций произошло ошибка");
            },
            error: function () {
            }
        });
    };

    // #endregion remove cart =======================================

    // #region close modal window =======================================

    self.closeModalWindow = function () {
        $('.window').hide();
        $('#mask').hide();
    };

    // #endregion close modal window =======================================

    // #region revert product =======================================

    self.revertProduct = function () {
        self.closeModalWindow();
        $('.detail-info').addClass('fadeOutRight');
        setTimeout(function () {
            $('.category-list').removeClass('passive');
            $('.detail-info').remove();
        }, 700);
    };

    // #endregion revert product =======================================

    // #region modified(plus or minus) item cart =======================================

    self.modifiedItemCart = function (itSelf, event) {
        var quentity = $($(event.target).parent()[0]).children('span').text();
        if (quentity > 1 || quentity == 1 && $(event.target).text() == '+') {
            $('.item-quentity a:first-child').css({ 'color': '#666' });
            var viewData = {
                productId: $($(event.target).parent()[0]).data('product-id'),
                mark: $(event.target).text()
            };
            $.ajax({
                url: '/Cart/ModifiedItemCart/',
                type: 'POST',
                data: viewData,
                success: function (data) {
                    if (data != "True")
                        alert("Во время операций произошло ошибка");
                    else {
                        if ($(event.target).text() == '-')
                            $($(event.target).parent()[0]).children('span').text(--quentity);
                        else $($(event.target).parent()[0]).children('span').text(++quentity);
                    };
                },
                error: function () {
                }
            });
        } else $(event.target).css({ 'color': '#DBD3D3' });
    };

    // #endregion modified(plus or minus) item cart =======================================

    // #region create new product =======================================

    self.Name = ko.observable(null);
    self.Price = ko.observable(null);
    self.Color = ko.observable(null);
    self.Date = ko.observable(null);
    self.Bluetooth = ko.observable(false);
    self.WiFi = ko.observable(false);
    self.Manufacturers = ko.observable(null);
    self.Display = ko.observable(null);
    self.RAM = ko.observable(null);
    self.OperatingSystem = ko.observable(null);
    self.Processor = ko.observable(null);
    self.BuildMemory = ko.observable(null);
    self.Camera = ko.observable(null);
    self.HadrDisk = ko.observable(null);
    self.VideoCard = ko.observable(null);

    self.creteProduct = function () {
        var viewData = {
            Name: self.Name(),
            Price: self.Price(),
            Color: self.Color(),
            Date: $('#Date').val(),
            Bluetooth: self.Bluetooth(),
            WiFi: self.WiFi(),
            Manufacturers: { Id: self.Manufacturers() },
            Display: { Id: self.Display() },
            TypeProduct: self.selectedItems()[0],
            RAM: self.RAM(),
            OperatingSystem: self.OperatingSystem(),
            Processor: { Id: self.Processor() },
            BuildMemory: self.BuildMemory(),
            Camera: { Id: self.Camera() },
            HardDisk: { Id: self.HadrDisk() },
            VideoCard: { Id: self.VideoCard() },
            Images: { Url: self.selectFile() }
        };
        $.ajax({
            url: '/api/Products/',
            type: 'POST',
            data: viewData,
            success: function (data) {
                alert(data);
                self.startUpload();
            },
            error: function () {
            }
        });
    };

    // #endregion create new product =======================================

    // #region entry check =======================================

    self.cartId = ko.observable(null);
    self.webMoney = ko.observable(null);
    self.totalPrice = ko.computed(function () {
        return self.webMoney() * 194;
    }, this);

    self.entryCheck = function () {
        var viewData = {
            check: {
                CardId: self.cartId(),
                Money: self.totalPrice()
            }
        };
        $.ajax({
            url: '/Check/EntryCheck/',
            type: 'POST',
            data: viewData,
            success: function (data) {
                if (data == "True")
                    alert("Заказ успешно оформлен");
                else alert("Во время операций произошло ошибка");
            },
            error: function () {
            }
        });
    };

    // #endregion entry check =======================================

    // #region remove check =======================================

    self.removeCheck = function (itSelf, event) {
        var viewData = {
            check: {
                Id: $(event.target).data('checkid')
            }
        };
        $.ajax({
            url: '/Check/DeleteCheck/',
            type: 'POST',
            data: viewData,
            success: function (data) {
                if (data == "True") {
                    alert("Заказ удален");
                    $(event.target).parent().parent().remove();
                }
                else alert("Во время операций произошло ошибка");
            },
            error: function () {
            }
        });
    };

    // #endregion remove check =======================================
};

