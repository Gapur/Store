function RegisterDataModel() {
    var self = this;
    self.LastName = ko.observable(null);
    self.FirstName = ko.observable(null);
    self.Email = ko.observable(null);
    self.Password = ko.observable(null);
    self.ConfirmPassword = ko.observable(null);

    self.registerate = function () {
        var model = {
            fullname: self.LastName() + self.FirstName(),
            email: self.Email(),
            password: self.Password()
        }; 
        $.ajax({
            url: '/Account/Register',
            type: 'POST',
            data: model,
            success: function (data) {
                alert("Вы успешно зарегистрировались!");
            },
            error: function () {
                alert("error");
            }
        });
    };
}