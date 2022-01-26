function BootstrapSidebarMenu($)
{
	this.SearchServiceUrl;
	this.SearchMinChars;
	this.SearchHelperDescription;
	this.SidebarMainClass;
	this.HeaderClass;
	this.SearchInputClass;
	this.SearchIconClass;
	this.SearchHelperClass;
	this.SearchResultClass;
	this.SidebarMenuClass;
	this.SidebarMenuOptionsData;  
	this.GAMOAuthToken;
	this.SelectedItem = 0;
	ucSidebar = this; 

	// Databinding for property SidebarMenuOptionsData

	this.ResetSelectedOption =function()
	{
		
		this.setActiveItem(1);
		var activeItem = this.getActiveItem(); 
		this.openItem(activeItem);	
	}

	this.SetSidebarMenuOptionsDataOptionsData = function(data)
	{
		///UserCodeRegionStart:[SetSidebarMenuOptionsDataOptionsData] (do not remove this comment.)

		if (data != undefined && data.length > 0){
			this.SidebarMenuOptionsData = data;
		} 
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}

	// Databinding for property SidebarMenuOptionsData
	this.GetSidebarMenuOptionsDataOptionsData = function()
	{
		///UserCodeRegionStart:[GetSidebarMenuOptionsDataOptionsData] (do not remove this comment.)

		return this.SidebarMenuOptionsData;	
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}
	

	this.show = function()
	{
		///UserCodeRegionStart:[show] (do not remove this comment.)
		
		//if (!this.IsPostBack || $(window).width() <= 767 ) {
			try{   
				var _idCount = 0,
				container = this.getContainerControl(),
				containerId = container.id, 
				containerName = this.ContainerName;   
				
				var _sidebarMainClass = this.SidebarMainClass || "page-sidebar",
				_headerClass = this.HeaderClass || "sidebar-header-wrapper",
				_headerSearchInputClass = this.SearchInputClass || "searchinput",
				_headerSearchIconClass = this.SearchIconClass || "searchicon fa fa-search",			
				_headerSearchHelperClass = this.SearchHelperClass || "searchhelper",
				_headerSearchResultClass = this.SearchResultClass || "searchresult",
				_sidebarMenuClass = this.SidebarMenuClass || "nav sidebar-menu";
				
				var buffer = '<div class="' + _sidebarMainClass + '" id="sidebar">'
				
				//Page Sidebar Header 
				if(this.SearchServiceUrl && this.SearchServiceUrl != "")
				{
					buffer += '<div class="' + _headerClass + '">'
					+ '<input type="text" id="sidebar_search_input"  autocomplete="false" autocorrect="off" autocapitalize="off"  class="' + _headerSearchInputClass + '" />'
					+ '<i class="' + _headerSearchIconClass + '"></i>'
					+ '<i class="searchreset fa-fw fa fa-times"></i>'
					
					if(this.SearchHelperDescription && this.SearchHelperDescription !="")
					{
						buffer += '<div class="' + _headerSearchHelperClass + '">' + this.SearchHelperDescription + '</div>';
						
						buffer += '<div id="sidebar_search_result" style="display:none;" class="' + _headerSearchResultClass + '"></div>';
					}
					buffer += '</div>';
				}
				//Page Sidebar Header 
			
				buffer += '<ul class="' + _sidebarMenuClass + '">';
				
				//load menu items
				jQuery.each( this.SidebarMenuOptionsData, 
					function(key,val){  
						buffer += '<li>'
							+ _sidebarMenuRecursiveLoad(key, val)
							+ '</li>';
					}
				);
				
				buffer += 	'</ul>';
				buffer += '</div>';
	   
				container.innerHTML = buffer;
				 
				//----------------------------
				// Sidebar Menu Click Handler
				//----------------------------
				jQuery(".sidebar-menu")
					.on('click', function (ev) {
						var menuLink = $(ev.target).closest("a");
						return ucSidebar._clickHandler(menuLink,ev);
					});

				jQuery(".sidebar-menu")
					.on('click', function (ev) {
						var menuLink = $(ev.target).closest("a");
						var a= menuLink.get(0);
						if(a && $(a).attr("href") != "#"){
							window.aux=true;									
						};
				});

				if (window.aux) {
					//set active item and open it.
					var activeItem = this.getActiveItem(); 
					this.openItem(activeItem);	
				}
				else {
					this.setActiveItem(1);
					var activeItem = this.getActiveItem(); 
					this.openItem(activeItem);			
				};	
				
				//----------------------------
				// search handler	
				//----------------------------				
				jQuery('#sidebar_search_input')
					.on("input", function(ev) {
						//var keycode = (ev.keyCode ? ev.keyCode : ev.which);
						if( this.value.length >= ucSidebar.SearchMinChars){
							return ucSidebar.onSearchExec(ev,this.value);
						} 					
						//if (keycode == '13') //enter 
					}); 
				
				/*workaround for html structure (temp?)
				Valid structure:
				<div id="PAGECONTAINER_MPAGE" class="page-container" style="">
					<div class="page-sidebar menu-compact" id="sidebar">*/
				var pageContainer = jQuery("div.page-container");
				var pageSidebar = jQuery("div.page-sidebar");
				
				if(pageContainer.length > 0 && pageSidebar.length > 0){
					var child = pageContainer.children().get(0);
					if( child && child.id != 'sidebar'){
						//replace first child with sidebar...
						var jChild = $(child);
						pageSidebar.detach().prependTo(pageContainer) ;
						jChild.remove();
					}
				}
				
				//search result handlers
				/*$("#sidebar_search_result")
					.mouseleave(function() { 
						$(this).prop("style","display:none");
					});*/
				$(".page-sidebar .sidebar-header-wrapper .searchreset")
					.on('click',function() { 
						$('#sidebar_search_input').val('');
						$("#sidebar_search_result").html(''); 
					});
				
				
				//----------------------------
				// fixed state
				//----------------------------
				if (readCookie("sidebar-fixed") != null) {
					if (readCookie("sidebar-fixed") == "true") {
						$('#checkbox_fixedsidebar').prop('checked', true);
						$('.page-sidebar').addClass('sidebar-fixed');
						$('.main-container').addClass('main-container-sidebar-fixed')

						//Slim Scrolling for Sidebar Menu in fix state
						if (!$(".page-sidebar").hasClass("menu-compact")) { 
							var height = 45;
							if(this.SearchServiceUrl && this.SearchServiceUrl != "")
								height = 90;
								
							$('.sidebar-menu').slimscroll({
								height:  $(window).height() - height,
								position: 'left',
								size: '3px',
							});
							a = $('.sidebar-menu').get(0);
							a.style.setProperty("overflow", "hidden", "important");
						}
					}

				}	
				$(".page-content").removeClass("hideMenu");
				this.display();
				
				//notification for other UCs
				gx.fx.obs.notify('dvelop.extuc.sidebar.init', null);
			}
			catch(ex) {
				gx.dbg.write(ex.toString());
			}
		//}
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}
	///UserCodeRegionStart:[User Functions] (do not remove this comment.)
	this._clickHandler = function (menuLink,ev){
		if (!menuLink || menuLink.length == 0)
			return;
		
		var b = $("#sidebar").hasClass("menu-compact");
		if (!menuLink.hasClass("menu-dropdown")) {
			if (b && menuLink.get(0).parentNode.parentNode == this) {
				var menuText = menuLink.find(".menu-text").get(0);
				if (ev && ev.target != menuText && !$.contains(menuText, ev.target)) { 
					return false;
				}
			} 
			if(ev)
				ucSidebar.onSelectedItemExec(ev, menuLink.get(0));
			return;
		}
		var submenu = menuLink.next().get(0);
		if (!$(submenu).is(":visible")) {
			var c = $(submenu.parentNode).closest("ul");
			if (b && c.hasClass("sidebar-menu"))
				return;
			c.find("> .open > .submenu")
				.each(function () {
					if (this != submenu && !$(this.parentNode).hasClass("active"))
						$(this).slideUp(200).parent().removeClass("open");
				});
		}
		if (b && $(submenu.parentNode.parentNode).hasClass("sidebar-menu")) 
			return false;
		$(submenu).slideToggle(200).parent().toggleClass("open"); 
		return false;
	}
	
	function _sidebarMenuRecursiveLoad(key, val) { 
		
        //actualFunction(key, val); 
		_buffer = "";		
        var value = val['subItems'];
        if (value instanceof Object && value.length > 0) {
			//add submenu item
			_buffer += '<a href="#" class="menu-dropdown">'
				+ '<i class="' + val.iconClass + '"></i>'
				+ '<span class="menu-text">' + val.caption + ' </span>'
				+ '<i class="menu-expand"></i>'
			+ '</a>'
			+ '<ul class="submenu">';
			
			//recursive call
            $.each(value, function(key, val) {
                _buffer += '<li>' + _sidebarMenuRecursiveLoad(key, val) + '</li>';
            });
			
			//close sub menu item
			_buffer += '</ul>';
			
		} else {
			//link/click action available
			_link = val.link || "#";
			_linkTarget = val.linkTarget || "";
			val.id = jQuery.trim(val.id);
			
			_activeClass = "";
			
			if(val.id === ucSidebar.getActiveItem() )
				_activeClass = "active"; 
				
			
			//add menu item
			_buffer += '<li class="' + _activeClass + '">'
				+ '<a href="' + _link + '"' + ' id="' + val.id + '"';
			//target link
			if(_link != "#")
				_buffer += ' target="' + _linkTarget + '"';
			//else
				//data click
				//_buffer += ' data-click="true"';
			
			_buffer += '>'
			if(val.iconClass && val.iconClass!="")
				_buffer+= '<i class="' + val.iconClass + '"></i>'
			
			_buffer+= '<span class="menu-text">' + val.caption + '</span>'
				+ '</a>'
			+ '</li>';
        }
		return _buffer;
    }
	
	this.onSelectedItemExec = function(ev,a) {  
		try{ 
			//inactive 
			this.setInactiveItem(this.getActiveItem());
			
			//active
			this.SelectedItem = a.id || 0;
			this.setActiveItem(this.SelectedItem); 
			
			//execute gx event or link
			if(a && $(a).attr("href") != "#")
				return false;
			this.OnSelectedItem();  //gx event
			
		} catch(ex) {
			gx.dbg.write(ex.toString());
		}
		return true; 
    } 
	
	this.onSearchExec = function(ev,searchTxt) { 
		try{ 
			 
			var restURL = window.location.href;
			restURL = restURL.substring(0, restURL.length - window.location.search.length);
			restURL = restURL.substring(0, restURL.lastIndexOf('/'));
			var lastIndexOfQ = restURL.lastIndexOf('?');
			if (lastIndexOfQ >= 0) {
				restURL = restURL.substring(0, lastIndexOfQ);
				restURL = restURL.substring(0, restURL.lastIndexOf('/'));
			}
			if (restURL.lastIndexOf('/servlet') == restURL.length - 8) {
				restURL = restURL.substring(0, restURL.length - 8);
			}
			restURL = restURL + '/rest/' + ucSidebar.SearchServiceUrl.split(".").join("/"); 
			
			//start load animation
			_requestAnimation(true);
			
			$.ajax({
				async: true,
				type: "POST",
				url: restURL,
				headers: {
					"Authorization": ucSidebar.GAMOAuthToken
				},
				contentType: "application/json",
				data: '{"SearchText": "' + searchTxt + '"}',
				success: function (result) {
					_processSearchResult(result);
				},
				error: function (jqXHR, textStatus, errorThrown) {
					_requestAnimation(false);
					
					console.log("errorThrown " + errorThrown);
					if (jqXHR != null && jqXHR.status == 401) {
						//401 (Not Authorized) -> Reload page so the user will be redirected to login
						window.location.reload();
					} else { 
						var container = $("#sidebar_search_result");
						var buffer = '<ul>';
							buffer += '<li class="alert alert-danger fade in">'
										+ '<i class="fa-fw fa fa-times"></i>'
										+ "Error " + jqXHR.status + ". " + errorThrown
									+ '</li>'  
						buffer += '</ul>';
						container.html(buffer);
						container.show();
						$(".page-sidebar .sidebar-header-wrapper .searchhelper").hide();
					}
				}
			});   
		} catch(ex) {
			gx.dbg.write(ex.toString());
		}
        return true;
    }
	
	function _processSearchResult(response){
		var container = $("#sidebar_search_result");
		var result = [];
		var error = false;
		
		try {
			var s = cleanJsonString(response.ResultJson); 
			result = jQuery.parseJSON(s); 
		} catch(e){
			error = true;
			result = [{"id":"error","text":"Error when processing response.","link":""}];
		} 
		 
		var buffer = '<ul class="search-result-body">';
		$.each(result, function(i,o){ 
			var text = o.text || "";
			var _iconFontClass = o.iconFontClass || "";
			var _class = o.itemClass || "search-result-item";
			var _link = o.link || "#";		
			if( o.id && o.id.toLowerCase().indexOf("error")>=0 
				|| o.id && o.id.toLowerCase().indexOf("warning")>=0
				|| o.id && o.id.toLowerCase().indexOf("info")>=0) { 
				
				error = true;
				_class = o.id.toLowerCase();
				var _iconClass = _class; 
				if(o.id.toLowerCase().indexOf("error")>=0){
					_class = "danger"; 
					_iconClass = "times";
				}
				
				buffer += '<li class="alert alert-' + _class +' fade in">'
						+ '<i class="fa-fw fa fa-' + _iconClass + '"></i>'
						+ jQuery.trim(text);
						+ '</li>'  
				
			} else {
				//result item
				buffer += '<li class="' + _class + '">';
				if(_iconFontClass)
					buffer += '<i class="' + _iconFontClass + '"></i>';
				buffer += '<a href="' + _link + '">' + jQuery.trim(text) + '</a>'; 
				buffer += '</li>';
			} 
			
		});
		buffer += '</ul>';
		
		//footer
		if(!error)
			buffer+= '<ul class="search-result-footer"><li>' + result.length + ' results found</li></ul>'
		
		container.html(buffer);
		container.show();
		$(".page-sidebar .sidebar-header-wrapper .searchhelper").hide();
		_requestAnimation(false);
	}
	
	function _requestAnimation(start){
		if(start) //start
			$('.page-sidebar .sidebar-header-wrapper .searchicon')
				.removeClass('fa-search')
				.addClass('fa-spinner fa-spin');
		else //stop
			$('.page-sidebar .sidebar-header-wrapper .searchicon')
				.removeClass('fa-spinner fa-spin')
				.addClass('fa-search');	
	}
	
	this.getActiveItem = function() {
		var itemId = readCookie("DVelopBootstrap_SidebarMenuSelected") || 0;
		ucSidebar.SelectedItem = itemId; /*used in gx uc*/
		return itemId;
	}
	this.setActiveItem = function(id){  	  
		var a = $(".page-sidebar a[id='" + jQuery.trim(id) + "']");
		if(a && a.length > 0){ 
			//remember active item
			createCookie("DVelopBootstrap_SidebarMenuSelected",id);	
			//add active class to item
			a.closest("li").toggleClass("active");
		}	
	}
	this.setInactiveItem = function(id){   
		var a = $(".page-sidebar a[id='" + jQuery.trim(id)  + "']");
		if(a && a.length > 0){
			//remove active
			a.closest("li").removeClass("active"); 
			createCookie("DVelopBootstrap_SidebarMenuSelected","");	
		}	
	}
	this.openItem = function(id){
		if(id && id !=""){
			
			var a = $(".page-sidebar a[id='" + jQuery.trim(id)  + "']");
			var b = $("#sidebar").hasClass("menu-compact");  
			
			if( !b && a && a.length == 1){  
				var submenus = a.parents("ul");
				$.each(submenus, function(i,submenu){
					submenu = $(submenu);
					if(submenu.hasClass("submenu") ){
						var li = submenu.closest("li");
						li.toggleClass("open"); 
						submenu = submenu.closest("ul"); 
					} else {
						if(submenu.hasClass("sidebar-menu"))
							return false;
					}
				}); 
			}
		}
	}
	
	this.display = function(state){
			
		if(!state || state == "")
			state = readCookie("DVelopBootstrap_SidebarMenu_State");
		
		if(state == "C") {
			ucSidebar.Collapse();			
		} else if(state == "H"){
			ucSidebar.hide();
		} else {
			ucSidebar.Expand();
		}
		
		if ($(window).width() <= 500)
		{
			$("#sidebar").toggleClass("hide");
			$(".page-content").toggleClass("hideMenu");
			$(".sidebar-toggler").toggleClass("active");
			createCookie("DVelopBootstrap_SidebarMenu_State","C");	
		}

	}
	this.Expand = function(){

		createCookie("DVelopBootstrap_SidebarMenu_State", "E");
		
		$(".page-content").removeClass("hideMenu");
		
		var b = $("#sidebar").hasClass("menu-compact"); 
		var f = $('.page-sidebar').hasClass('sidebar-fixed')
		
		if (!$('#sidebar').is(':visible'))
			$("#sidebar").removeClass("hide");
		$(".sidebar-collapse").removeClass("active");
		$(".sidebar-toggler").removeClass("active");
		$(".page-content").removeClass("menu-compact");
		$('.page-sidebar').removeClass("menu-compact");
		
		if (!$(".sidebar-menu").closest("div").hasClass("slimScrollDiv")) {
			var height = 45;
			if(this.SearchServiceUrl && this.SearchServiceUrl != "")
				height = 90;
			$('.sidebar-menu').slimscroll({
				height: $(window).height() - height,//'auto',
				position: 'left',
				size: '3px',
			});
			a = $('.sidebar-menu').get(0);
			a.style.setProperty("overflow", "hidden", "important");
		}
	    //Update Totalizer and Pagination Bar Sizes
		var totalizerGrids = $('table.GridWithTotalizer').length;
		if (totalizerGrids > 0)
		    SetMinWidthTotalizers();

		var paginationBars = $('table.GridWithPaginationBar').length;
		if (paginationBars > 0)
		    SetMinWidthPaginationBars();
	}
	this.CollapseExpand = function(){
	
		var state = readCookie("DVelopBootstrap_SidebarMenu_State");
		if (state == "C")
		{
			ucSidebar.Expand();
		}
		else if (state == "E")
		{
			ucSidebar.Collapse();
		}
	}
	this.Collapse = function(){
		
		createCookie("DVelopBootstrap_SidebarMenu_State", "C");
		
		//Sidebar Collapse
		var b = $("#sidebar").hasClass("menu-compact");
		
		if (!$('#sidebar').is(':visible'))
			$("#sidebar").toggleClass("hide");
		$("#sidebar").toggleClass("menu-compact");
		$(".sidebar-collapse").toggleClass("active");
		b = $("#sidebar").hasClass("menu-compact");
		
		$(".page-content").removeClass("menu-compact");
		$(".page-content").toggleClass("menu-compact");
		
		if ($(".sidebar-menu").closest("div").hasClass("slimScrollDiv")) {
			$(".sidebar-menu").slimScroll({ destroy: true });
			$(".sidebar-menu").attr('style', '');
		}
		if (b) {
			$(".open > .submenu")
				.removeClass("open");
		} else {
			if ($('.page-sidebar').hasClass('sidebar-fixed')) {
				var position = (readCookie("rtl-support") || location.pathname == "/index-rtl-fa.html" || location.pathname == "/index-rtl-ar.html") ? 'right' : 'left';
				var height = 45;
				if(this.SearchServiceUrl && this.SearchServiceUrl != "")
					height = 90;
				$('.sidebar-menu').slimscroll({
					height: $(window).height() - height, //'auto',
					position: position,
					size: '3px',
				});
				a = $('.sidebar-menu').get(0);
				a.style.setProperty("overflow", "hidden", "important");
			}
		}
		//Slim Scroll Handle  
		
        //Update Totalizer and Pagination Bar Sizes
		var totalizerGrids = $('table.GridWithTotalizer').length;
		if (totalizerGrids > 0)
			SetMinWidthTotalizers();
			
		var paginationBars = $('table.GridWithPaginationBar').length;
		if (paginationBars > 0)
			SetMinWidthPaginationBars();	
	}
	this.hide = function(){
		createCookie("DVelopBootstrap_SidebarMenu_State", "H"); 
		$("#sidebar").removeClass("hide").addClass("hide");
		$(".sidebar-toggler").removeClass("active").addClass("active");
		$(".page-content").toggleClass("hideMenu");
	}
	 
	$(window)
    .load(function () {
		
		
		
		//External UC handlers
		//Sidebar header Toggler : <-> header button
		$(".sidebar-toggler").on('click', function () {  
			var h = $("#sidebar").hasClass("hide");
			//set state
			if(h)
				ucSidebar.Expand();
			else 
				ucSidebar.hide();
			return false;
		});
		//End Sidebar header Toggler 
		
    });
	
	 			

		 
	///UserCodeRegionEnd: (do not remove this comment.):
}
