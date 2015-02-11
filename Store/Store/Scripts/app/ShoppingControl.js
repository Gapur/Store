function ShopDataModel() {
    var self = this;

    // #region put the product in the basket =======================================

    self.productId = ko.observable($('.product-buy input').val());
    self.imageUrl = ko.observable($('.product-image img').attr('src'));
    self.productName = ko.observable($('.detail-info > h2 > span').text());
    self.price = ko.observable($('.product-buy .price').text());

    self.putInBasket = function () {
        var viewData = {
            Id: self.productId(),
            Name: self.productName(),
            ImageUrl: self.imageUrl(),
            Price: self.price()
        };
        $.ajax({
            url: '/Cart/AddToCart/',
            type: 'POST',
            data: viewData,
            success: function (data) {
                alert("ok");
                $('#dialog .title').text(self.productName());
                $('#dialog .description span').text(self.productName());                
                fadeModalWindow();
            },
            error: function () {
            }
        });

        // #region open modal window =======================================

        function fadeModalWindow() {
            $('#mask').css({ 'width': $('body').width(), 'height': $('body').height() });

            $('#mask').fadeIn(1000);
            $('#mask').fadeTo("slow", 0.8);

            var winH = $(window).height();
            var winW = $(window).width();

            $('#dialog').css('top', winH / 2 - $('#dialog').height() / 2);
            $('#dialog').css('left', winW / 2 - $('#dialog').width() / 2);

            $('#dialog').fadeIn(2000);
        };

        // #endregion open modal window =======================================
    };

    // #endregion put the product in the basket ======================================

    // #region callback product =======================================

    self.callBack = function () {
        $('.detail-info').addClass('fadeOutRight');
        setTimeout(function () {
            $('.category-list').removeClass('passive');
            $('.detail-info').remove();
        }, 700);
    };

    // #endregion callback product =======================================
}