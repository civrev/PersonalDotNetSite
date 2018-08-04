window.onload = function(){
	window.onscroll = function() {stickyNavbar()};

	var navbar = document.getElementById("topnav");
	var stickydiv = document.getElementById("topcontent");
	var sticky = navbar.offsetTop;

	var menu = document.getElementById("menu-btn");
	var dropdown = document.getElementById("dropdown-content");
	menu.onclick = function() {showMenu()};

	function stickyNavbar() {
		if (window.pageYOffset >= sticky) {
			navbar.classList.add("sticky");
			stickydiv.classList.add("sticky");
		} else {
			navbar.classList.remove("sticky");
			stickydiv.classList.remove("sticky");
		}
	}

	function showMenu() {
		if(dropdown.style.display === "none"){
			window.scrollTo(0, sticky); //origianl navbar pos
			dropdown.style.display = "flex";
		}else{
			dropdown.style.display = "none";
		}
	}
};