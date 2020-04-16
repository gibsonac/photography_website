// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// (function ($) {
$(document).ready(function () {

    // fade in .navbar
    $(function () {
        $(window).scroll(function () {
            // set distance user needs to scroll before we fadeIn navbar
            if ($(this).scrollTop() > 50) {
                $('.navbar')
                    .css('background-color', 'white')
                    .css('box-shadow', '0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19');


            } else {
                $('.navbar')
                    .css('background-color', 'transparent')
                    .css('box-shadow', 'none');
            }
        });

        // THE SLIDE SHOW OF IMAGES
        // var images = new Array('/images/P3160063.jpg', '/images/IMG_7889.jpg', '/images/IMG_8964.jpg');
        var images = new Array('/images/bangka.jpg', '/images/joshuatree.jpg', '/images/manta.jpg', '/images/splitShot.jpg', '/images/surf.jpg', '/images/turtle.jpg', '/images/_2150750.jpg');
        var nextimage = 0;
        // $('.homeBannerImage')
        //     .css('background-image', 'url("' + images[0] + '")');
        setTimeout(doSlideshow, 5000)
        // doSlideshow();
        function doSlideshow() {
            if (nextimage >= images.length) { nextimage = 0; }
            $('.homeBannerImage')
                .fadeOut(1000, function () {
                    $('.homeBannerImage')
                        .css('background-image', 'url("' + images[nextimage++] + '")')
                        .fadeIn(2000, function () {
                            setTimeout(doSlideshow, 5000);
                        })
                });
        }
    });
}(jQuery));
