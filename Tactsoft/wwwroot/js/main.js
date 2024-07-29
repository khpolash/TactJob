(function() {

	/* ====Sticky Navbar Start==== */
	$(function(){
		var myNav = $('.navbar');
		$(window).scroll(function(){
			if($(window).scrollTop() <= 50){
				myNav.removeClass('sticky-nav');
			}else{
				myNav.addClass('sticky-nav');
			}
		})
	})
	/* ====Sticky Navbar End==== */

	/* ====Button (Scrolling Bottom to Top) Start==== */
	var mybtn = document.getElementById('scroll-bottom-top');
	window.onscroll = function() {
		scrollFunction();
	};

	function scrollFunction() {
		if (
			document.body.scrollTop > 50 ||
			document.documentElement.scrollTop > 50
			) {
			mybtn.style.opacity = '1';
	} 
	else {
		mybtn.style.opacity = '0';
	}
}
mybtn.addEventListener('click', topFunction);

function topFunction() {
	document.body.scrollTop = 0;
	document.documentElement.scrollTop = 0;
}
/* ====Button (Scrolling Bottom to Top) End==== */


/* ====Job Role Slider Start==== */
$('#job-role-slider').slick({
	dots: true,
	infinite: true,
	speed: 1000,
	autoplay: true,
	autoplaySpeed: 1500,
	autoplayHoverPause: true,
	slidesToShow: 1,
	slidesToScroll: 1,
	responsive: [
	{
		breakpoint: 1024,
		settings: {
			slidesToShow: 1,
			slidesToScroll: 1,
			infinite: true,
			dots: true
		}
	},
	{
		breakpoint: 600,
		settings: {
			slidesToShow: 1,
			slidesToScroll: 1
		}
	},
	{
		breakpoint: 480,
		settings: {
			slidesToShow: 1,
			slidesToScroll: 1
		}
	}
	]
});

/* ====Job Role Slider End==== */


/* ====Profile Page Side Nav Dropdown Start==== */
var dropdownBtns = document.getElementsByClassName("dropdown-btn");

for (var i = 0; i < dropdownBtns.length; i++) {
	dropdownBtns[i].addEventListener("click", function() {
		this.classList.toggle("active");
		var dropdownContainer = this.nextElementSibling;
		if (dropdownContainer.style.display === "block") {
			dropdownContainer.style.display = "none";

		} else {
			dropdownContainer.style.display = "block";
		}
	});
	}


/* ====Profile Page Side Nav Dropdown End==== */


/* ====Profile Page Side Nav Dropdown Start==== 
$(".side-nav .dropdown-btn").on("click", function(){
	$(".side-nav .dropdown-btn").removeClass("active");
	$(this).addClass("active");
});

$(".side-nav .manageResume-btn").on("click", function(){
	$("#manage-resume").slideDown(1000);
	$("#invitation, #my-activities, #employer-activites, #assessment, #personalization").slideUp(1000);
});
$(".side-nav .invitation-btn").on("click", function(){
	$("#invitation").slideDown(1000);
	$("#manage-resume, #my-activities, #employer-activites, #assessment, #personalization").slideUp(1000);
});
$(".side-nav .myActivites-btn").on("click", function(){
	$("#my-activities").slideDown(1000);
	$("#manage-resume, #invitation, #employer-activites, #assessment, #personalization").slideUp(1000);
});
$(".side-nav .employerActivites-btn").on("click", function(){
	$("#employer-activites").slideDown(1000);
	$("#manage-resume, #invitation, #my-activities, #assessment, #personalization").slideUp(1000);
});
$(".side-nav .assessment-btn").on("click", function(){
	$("#assessment").slideDown(1000);
	$("#manage-resume, #invitation, #my-activities, #employer-activites, #personalization").slideUp(1000);
});
$(".side-nav .personalization-btn").on("click", function(){
	$("#personalization").slideDown(1000);
	$("#manage-resume, #invitation, #my-activities, #employer-activites, #assessment").slideUp(1000);
});
 ====Profile Page Side Nav Dropdown End==== */







})()