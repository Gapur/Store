function ShopDataModel() {
    var self = this;

    // #region put the product in the basket =======================================

    self.productId = ko.observable($('.product-buy input').val());
    self.imageUrl = ko.observable($('.product-image img').attr('src'));
    self.productName = ko.observable($('.detail-info>h2>span').text());
    self.price = ko.observable($('.product-buy .price').text());

    self.putInBasket = function () {
        var viewData = {
            Id: self.productId(),
            Name: self.productName(),
            ImageUrl: self.imageUrl(),
            Price: self.price()
        };
        debugger
        $.ajax({
            url: '/Cart/AddToCart/',
            type: 'POST',
            data: viewData,
            success: function (data) {
                alert("ok");
            },
            error: function () {
            }
        });
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