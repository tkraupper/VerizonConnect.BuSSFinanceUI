

////////////////////////////NAVBAR LOGIC////////////////////////

var numberOfItems = $('#loop .loop-row').length;
var limitPerPage = 15;
$("#loop .loop-row:gt(" + (limitPerPage - 1) + ")").hide();

var totalPages = Math.round(numberOfItems / limitPerPage);

$(".pagination").append("<li class='current-page active'><a href='javascript:void(0)'>" + 1 + "</a></li>");

for (var i = 2; i <= totalPages; i++) {
    $(".pagination").append("<li class='current-page'><a href='javascript:void(0)'>" + i + "</a></li>");
}

$(".pagination").append("<li id='next-page' class='page-item'><a class='page-link' href='javascript:void(0)' aria-label='Next'><span aria-hidden='true'>&raquo;</span></a ></li >");

$(".pagination li.current-page").on("click", function () {
    if ($(this).hasClass("active")) {
        return false;
    }
    else {
        var currentPage = $(this).index();
        $(".pagination li").removeClass("active");
        $(this).addClass("active");
        $("#loop .loop-row").hide();

        var grandTotal = limitPerPage * currentPage;

        for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
            $("#loop .loop-row:eq(" + i + ")").show();
        }
    }
});


/////////////////////////////////////NEXT PAGE BUTTON/////////////////////////////////////
$("#next-page").on("click", function () {
    var currentPage = $(".pagination li.active").index();
    if (currentPage === totalPages) {
        return false;
    }
    else {
        currentPage++;
        $(".pagination li").removeClass("active");
        $("#loop .loop-row").hide();

        var grandTotal = limitPerPage * currentPage;

        for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
            $("#loop .loop-row:eq(" + i + ")").show();
        }

        $(".pagination li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
    }
});


////////////////////////////////PREVIOUS PAGE BUTTON///////////////////////////////////////
$("#previous-page").on("click", function () {
    var currentPage = $(".pagination li.active").index();
    if (currentPage === 1) {
        return false;
    }
    else {
        currentPage--;
        //Adjust Navbar active button
        $(".pagination li").removeClass("active");
        //hide old data
        $("#loop .loop-row").hide();

        var grandTotal = limitPerPage * currentPage;

        for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
            $("#loop .loop-row:eq(" + i + ")").show();
        }

        $(".pagination li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
    }
});