function Alertify()
{
	this.Width;
	this.Height;
	this.Type;
	this.Delay;
	this.TextMessage;
	this.TextOk;
	this.TextCancel;
	this.PromptResponse;
	this.PromptPlaceholder;

	// Databinding for property PromptResponse
	this.SetPromptResponse = function(data)
	{
		///UserCodeRegionStart:[SetPromptResponse] (do not remove this comment.)
		this.PromptResponse = data;
		///UserCodeRegionEnd: (do not remove this comment.)
	}

	// Databinding for property PromptResponse
	this.GetPromptResponse = function()
	{
		///UserCodeRegionStart:[GetPromptResponse] (do not remove this comment.)
		return this.PromptResponse;
		///UserCodeRegionEnd: (do not remove this comment.)
	}

	this.show = function()
	{
		///UserCodeRegionStart:[show] (do not remove this comment.)
		if (window.isfirstalert){
			this.InitMessagesDefault();
			window.isfirstalert = false;
		}
		///UserCodeRegionEnd: (do not remove this comment.)
	}
	///UserCodeRegionStart:[User Functions] (do not remove this comment.)

	this.DoOk = function(resp){
		if (typeof this.Ok == 'function'){
			this.SetPromptResponse((resp != undefined)? resp : '' );
			this.Ok();
		}
	}

	this.Message = function(){
		var textcancel = (this.TextCancel == '')? 'CANCEL':this.TextCancel;
		var textok = (this.TextOk == '')? 'OK':this.TextOk;
		var delay = this.Delay*1;
		var message = this.TextMessage;
		var fok = this;

		alertify.set({ delay: (delay == 0? 5000: delay*1),
			labels:{
				ok: textok,
				cancel: textcancel
			}});
		
		switch(this.Type){
			case 'alert':
				alertify.alert(message, function (e) {
					if (e) {
						fok.DoOk();
					}
				});
			break;
			case 'confirm':
				alertify.confirm(message, function (e) {
					if (e) {
						fok.DoOk();
					}
				});
			break;
			case 'prompt':
				alertify.prompt(message, function (e, str) {
					if (e) {
						fok.DoOk(str);
					}
				});
				if ( this.PromptPlaceholder != '' ){
					$('.alertify-text').prop('placeholder',this.PromptPlaceholder);
				}
			break;
			case 'log':
				alertify.log(message);
			break;
			case 'success':
				alertify.success(message);
			break;
			case 'error':
				alertify.error(message);
			break;
		}
	}

	this.InitMessagesDefault = function(){
		gx.fx.obs.addObserver('gx.onmessages', this, this.ShowAlertifyLogs);
		if (!this.IsPostBack) {
			var listError = $('#gxErrorViewer').children();
	        var arrMessages = new Array();
	        $.each(listError, function(index, item) {
	            arrMessages.push({ text: $(item).html() });
	        });
	        this.ShowAlertifyLogs({MAIN:arrMessages});
		} else {
	    	this.setDefaultViewerMessages();
		}
	    gx.evt.on_ready(this, this.setDefaultViewerMessages);
	}

	this.setDefaultViewerMessages = function() {
		$("[id*=gxErrorViewer]").remove();
	}

	this.ShowAlertifyLogs = function(messages) {
		var delay = this.Delay*1;
		alertify.set({ delay: (delay == 0? 5000: delay*1)});

		$.each(messages,function(index, item){
			$.each(item,function(iindex, iitem){
				alertify.log(iitem.text);
			});
		});
	}
	
	///UserCodeRegionEnd: (do not remove this comment.):
}
