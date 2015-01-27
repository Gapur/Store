function ProductViewModel() {

    self = this;

    self.getProducts = function () {
        $.ajax({
            url: '/api/Products/',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                alert(data);
            },
            error: function () {
                alert("error");
            }
        });
    };

}