$(document).ready(function() {
    $("#CategoryDD").change(function () {
        var selectedCategoryId = $("#CategoryDD").val();
        var jsonData = { categoryId: selectedCategoryId }; //json data

            $.ajax({
                url: "/Products/GetByCategory",
                data: jsonData,
                type: "POST",
                success: function(respons) {
                    $("#ProductDD").empty();

                    var options = "<option>Select.....</option>";
                    $.each(respons,
                        function (key, products) {
                        options += "<option value='" + products.Id + "'>" + products.Name + "</option>";
                    });

                    $("#ProductDD").append(options);
                },
                error:function() {
                    
                }
        });
    });

    
    var index = 0;

    $("#addButton").click(function () {
        var product = GetByProductForForm();
        var tableBody = $("#tbodyAddData");
        

        var indexCell = "<td style='display:none'><input type='hidden' name='StockInDetails.index' value='" + index + "'></td>";
        var productNameCell = "<td><input type='hidden' name='StockInDetails["+index+"].productId' value='"+product.ProductId+"'>"+product.ProductName+"</td>";
        var productQtyCell = "<td><input type='hidden' name='StockInDetails[" + index + "].Qty' value='" + product.Qty + "'>" + product.Qty + "</td>";
        var removeButton = "<td><input type='button' value='Remove' class='btn btn-default' /></td>";
        var tr = "<tr id='removeRow'>" + indexCell + productNameCell + productQtyCell + removeButton + "</tr>";
        tableBody.append(tr);
        ++index;

        //$("#removeRow").remove();
    });

    

});

function GetByProductForForm() {
    var productId = $("#ProductDD").val();
    var productName = $("#ProductDD option:selected").text();
    var qty = $("#Qty").val();
    return {ProductId:productId, ProductName:productName, Qty:qty}
}
