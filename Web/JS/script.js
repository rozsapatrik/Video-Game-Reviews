$(document).ready(function(){
    GetReviews();

    $(document).on("click", ".del", function(){
        let id = $(this).attr("data-id");
    
        $.ajax({
            url: "delete.php",
            method: "POST",
            data: {id: id},
            success: function(){
                GetReviews();
            },
            error: function(){
                alert("Couldn't delete review");
            },
        });
    });
});

function GetReviews()
{    
    $.get("getreviews.php", function(data, status){
        $(".reviews").html(data);
    });
}