function DeviceViewModel() {

    self = this;

    self.getDevices = function () {
        $.ajax({
            url: '/api/Devices/',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                alert("a");
            },
            error: function () {
                alert("error");
            }
        });
    };

    self.getManufacturers = function () {
        $.ajax({
            url: '/api/Manufacturers/',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                alert(data);
            },
            error: function (e) {
                alert(e);
            }
        });
    };

}