function ManufacturerActions() {

    self = this;

    self.getManufacturers = function () {
        $.ajax({
            url: '/api/Manufacturers/',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                alert(data);
            },
            error: function (e) {
                alert("error " + e);
            }
        });
    };
}