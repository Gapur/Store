function LoginDataModel() {
    var self = this;
    self.Email = ko.observable(null);
    self.Password = ko.observable(null);

    self.login = function (model) {
        var data = {
            email: self.Email(),
            password: self.Password()
        };
        $.ajax({
            url: '/Account/Login',
            type: 'POST',
            data: JSON.stringify(data),
            contentType: "application/json;charset=utf-8",
            success: function (data) {
                alert('Добро пожаловать!');
            },
            error: function () {
                alert('error');
            }
        });
    };
}