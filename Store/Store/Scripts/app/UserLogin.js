function LoginDataModel() {
    var self = this;
    self.Email = ko.observable(null);
    self.Password = ko.observable(null);

    self.login = function () {
        var model = {
            model: {
                email: self.Email(),
                password: self.Password()
            }
        };
        debugger;
        $.ajax({
            url: '/Account/Login',
            type: 'POST',
            data: model,
            success: function (data) {
                $($(".item-control")[0]).replaceWith(
                   $($($(data).children('.content')).children('.formItem')).children('.item-control')[0]);
            },
            error: function () {
                alert('error');
            }
        });
    };
}