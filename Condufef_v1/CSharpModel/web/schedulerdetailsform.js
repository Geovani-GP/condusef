/**@preserve  GeneXus C# 10_3_15-115824 on 2/15/2022 5:9:20.34
*/
gx.evt.autoSkip=!1;gx.define("schedulerdetailsform",!1,function(){this.ServerClass="schedulerdetailsform";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.e132b2_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e142b2_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[5,8,10,13,15,18,20];this.GXLastCtrlId=20;n[5]={fld:"TABLE1",grid:0};n[8]={fld:"TEXTBLOCK1",format:0,grid:0};n[10]={lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vEVENTID",gxz:"ZV8eventId",gxold:"OV8eventId",gxvar:"AV8eventId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8eventId=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8eventId=n)},v2c:function(){gx.fn.setControlValue("vEVENTID",gx.O.AV8eventId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8eventId=this.val())},val:function(){return gx.fn.getControlValue("vEVENTID")},nac:gx.falseFn};n[13]={fld:"TEXTBLOCK2",format:0,grid:0};n[15]={lvl:0,type:"dtime",len:8,dec:5,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vEVENTSTARTTIME",gxz:"ZV9eventStartTime",gxold:"OV9eventStartTime",gxvar:"AV9eventStartTime",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9eventStartTime=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9eventStartTime=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vEVENTSTARTTIME",gx.O.AV9eventStartTime,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9eventStartTime=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vEVENTSTARTTIME")},nac:gx.falseFn};n[18]={fld:"TEXTBLOCK3",format:0,grid:0};n[20]={lvl:0,type:"dtime",len:8,dec:5,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vEVENTENDTIME",gxz:"ZV7eventEndTime",gxold:"OV7eventEndTime",gxvar:"AV7eventEndTime",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7eventEndTime=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7eventEndTime=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vEVENTENDTIME",gx.O.AV7eventEndTime,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7eventEndTime=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vEVENTENDTIME")},nac:gx.falseFn};this.AV8eventId="";this.ZV8eventId="";this.OV8eventId="";this.AV9eventStartTime=gx.date.nullDate();this.ZV9eventStartTime=gx.date.nullDate();this.OV9eventStartTime=gx.date.nullDate();this.AV7eventEndTime=gx.date.nullDate();this.ZV7eventEndTime=gx.date.nullDate();this.OV7eventEndTime=gx.date.nullDate();this.AV8eventId="";this.AV9eventStartTime=gx.date.nullDate();this.AV7eventEndTime=gx.date.nullDate();this.Gx_mode="";this.Events={e132b2_client:["ENTER",!0],e142b2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(schedulerdetailsform)