/**@preserve  GeneXus C# 10_3_15-115824 on 2/4/2022 12:38:48.86
*/
gx.evt.autoSkip=!1;gx.define("detallesempleadospiso",!1,function(){var n,t;this.ServerClass="detallesempleadospiso";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e13362_client=function(){this.executeServerEvent("VUPDATEIMAGE.CLICK",!0,arguments[0],!1,!1)};this.e14362_client=function(){this.executeServerEvent("VDELETEIMAGE.CLICK",!0,arguments[0],!1,!1)};this.e11362_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e16362_client=function(){this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,5,7,12,13,14,15,16,17,18,19];this.GXLastCtrlId=19;this.EmpeladospisogridContainer=new gx.grid.grid(this,2,"WbpLvl2",11,"Empeladospisogrid","Empeladospisogrid","EmpeladospisogridContainer",this.CmpContext,this.IsMasterPage,"detallesempleadospiso",[],!1,1,!1,!0,0,!1,!1,!1,"",0,"px","Nueva fila",!1,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.EmpeladospisogridContainer;t.addSingleLineEdit(46,12,"EMPLEADOSPISOEXTID","ID","","empleadospisoextid","int",0,"px",9,9,"right",null,[],46,"empleadospisoextid",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(47,13,"EMPLEADOSPISOEXTPISO","Ext Piso","","empleadospisoextpiso","svchar",0,"px",10,10,"left",null,[],47,"empleadospisoextpiso",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(49,14,"EMPLEADOSPISOEXTCORREO","Correo","","empleadospisoextcorreo","svchar",0,"px",50,50,"left",null,[],49,"empleadospisoextcorreo",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(48,15,"EMPLEADOSPISOEXTEXT","Ext","","empleadospisoextext","svchar",0,"px",10,10,"left",null,[],48,"empleadospisoextext",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(51,16,"EMPLEADOSPISOEXTUSUARIO","Usuario","","empleadospisoextusuario","svchar",0,"px",15,15,"left",null,[],51,"empleadospisoextusuario",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(52,17,"EMPLEADOSPISOEXTFECGRE","Fec gre","","empleadospisoextfecgre","date",0,"px",10,10,"right",null,[],52,"empleadospisoextfecgre",!0,0,!1,!1,"Attribute",1,"");t.addBitmap("&Updateimage","vUPDATEIMAGE",18,0,"px",17,"px","e13362_client","","","Image","");t.addBitmap("&Deleteimage","vDELETEIMAGE",19,0,"px",17,"px","e14362_client","","","Image","");this.setGrid(t);n[2]={fld:"TABLE1",grid:0};n[5]={lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vBUSCAR",gxz:"ZV5buscar",gxold:"OV5buscar",gxvar:"AV5buscar",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV5buscar=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5buscar=n)},v2c:function(){gx.fn.setControlValue("vBUSCAR",gx.O.AV5buscar,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV5buscar=this.val())},val:function(){return gx.fn.getControlValue("vBUSCAR")},nac:gx.falseFn};n[7]={fld:"TEXTBLOCK1",format:0,grid:0};n[12]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:11,gxgrid:this.EmpeladospisogridContainer,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSPISOEXTID",gxz:"Z46empleadospisoextid",gxold:"O46empleadospisoextid",gxvar:"A46empleadospisoextid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A46empleadospisoextid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z46empleadospisoextid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPLEADOSPISOEXTID",n||gx.fn.currentGridRowImpl(11),gx.O.A46empleadospisoextid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A46empleadospisoextid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPLEADOSPISOEXTID",n||gx.fn.currentGridRowImpl(11),".")},nac:gx.falseFn};n[13]={lvl:2,type:"svchar",len:10,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.EmpeladospisogridContainer,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSPISOEXTPISO",gxz:"Z47empleadospisoextpiso",gxold:"O47empleadospisoextpiso",gxvar:"A47empleadospisoextpiso",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A47empleadospisoextpiso=n)},v2z:function(n){n!==undefined&&(gx.O.Z47empleadospisoextpiso=n)},v2c:function(n){gx.fn.setGridControlValue("EMPLEADOSPISOEXTPISO",n||gx.fn.currentGridRowImpl(11),gx.O.A47empleadospisoextpiso,0)},c2v:function(){this.val()!==undefined&&(gx.O.A47empleadospisoextpiso=this.val())},val:function(n){return gx.fn.getGridControlValue("EMPLEADOSPISOEXTPISO",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};n[14]={lvl:2,type:"svchar",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.EmpeladospisogridContainer,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSPISOEXTCORREO",gxz:"Z49empleadospisoextcorreo",gxold:"O49empleadospisoextcorreo",gxvar:"A49empleadospisoextcorreo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A49empleadospisoextcorreo=n)},v2z:function(n){n!==undefined&&(gx.O.Z49empleadospisoextcorreo=n)},v2c:function(n){gx.fn.setGridControlValue("EMPLEADOSPISOEXTCORREO",n||gx.fn.currentGridRowImpl(11),gx.O.A49empleadospisoextcorreo,0)},c2v:function(){this.val()!==undefined&&(gx.O.A49empleadospisoextcorreo=this.val())},val:function(n){return gx.fn.getGridControlValue("EMPLEADOSPISOEXTCORREO",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};n[15]={lvl:2,type:"svchar",len:10,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.EmpeladospisogridContainer,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSPISOEXTEXT",gxz:"Z48empleadospisoextext",gxold:"O48empleadospisoextext",gxvar:"A48empleadospisoextext",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A48empleadospisoextext=n)},v2z:function(n){n!==undefined&&(gx.O.Z48empleadospisoextext=n)},v2c:function(n){gx.fn.setGridControlValue("EMPLEADOSPISOEXTEXT",n||gx.fn.currentGridRowImpl(11),gx.O.A48empleadospisoextext,0)},c2v:function(){this.val()!==undefined&&(gx.O.A48empleadospisoextext=this.val())},val:function(n){return gx.fn.getGridControlValue("EMPLEADOSPISOEXTEXT",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};n[16]={lvl:2,type:"svchar",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.EmpeladospisogridContainer,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSPISOEXTUSUARIO",gxz:"Z51empleadospisoextusuario",gxold:"O51empleadospisoextusuario",gxvar:"A51empleadospisoextusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A51empleadospisoextusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z51empleadospisoextusuario=n)},v2c:function(n){gx.fn.setGridControlValue("EMPLEADOSPISOEXTUSUARIO",n||gx.fn.currentGridRowImpl(11),gx.O.A51empleadospisoextusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A51empleadospisoextusuario=this.val())},val:function(n){return gx.fn.getGridControlValue("EMPLEADOSPISOEXTUSUARIO",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};n[17]={lvl:2,type:"date",len:10,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.EmpeladospisogridContainer,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSPISOEXTFECGRE",gxz:"Z52empleadospisoextfecgre",gxold:"O52empleadospisoextfecgre",gxvar:"A52empleadospisoextfecgre",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A52empleadospisoextfecgre=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z52empleadospisoextfecgre=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("EMPLEADOSPISOEXTFECGRE",n||gx.fn.currentGridRowImpl(11),gx.O.A52empleadospisoextfecgre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A52empleadospisoextfecgre=gx.fn.toDatetimeValue(this.val()))},val:function(n){return gx.fn.getGridDateTimeValue("EMPLEADOSPISOEXTFECGRE",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};n[18]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.EmpeladospisogridContainer,fnc:null,isvalid:null,rgrid:[],fld:"vUPDATEIMAGE",gxz:"ZV7updateImage",gxold:"OV7updateImage",gxvar:"AV7updateImage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV7updateImage=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7updateImage=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATEIMAGE",n||gx.fn.currentGridRowImpl(11),gx.O.AV7updateImage,gx.O.AV10Updateimage_GXI)},c2v:function(){gx.O.AV10Updateimage_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV7updateImage=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATEIMAGE",n||gx.fn.currentGridRowImpl(11))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATEIMAGE_GXI",n||gx.fn.currentGridRowImpl(11))},gxvar_GXI:"AV10Updateimage_GXI",nac:gx.falseFn};n[19]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.EmpeladospisogridContainer,fnc:null,isvalid:null,rgrid:[],fld:"vDELETEIMAGE",gxz:"ZV6deleteImage",gxold:"OV6deleteImage",gxvar:"AV6deleteImage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV6deleteImage=n)},v2z:function(n){n!==undefined&&(gx.O.ZV6deleteImage=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETEIMAGE",n||gx.fn.currentGridRowImpl(11),gx.O.AV6deleteImage,gx.O.AV11Deleteimage_GXI)},c2v:function(){gx.O.AV11Deleteimage_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV6deleteImage=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETEIMAGE",n||gx.fn.currentGridRowImpl(11))},val_GXI:function(n){return gx.fn.getGridControlValue("vDELETEIMAGE_GXI",n||gx.fn.currentGridRowImpl(11))},gxvar_GXI:"AV11Deleteimage_GXI",nac:gx.falseFn};this.AV5buscar="";this.ZV5buscar="";this.OV5buscar="";this.Z46empleadospisoextid=0;this.O46empleadospisoextid=0;this.Z47empleadospisoextpiso="";this.O47empleadospisoextpiso="";this.Z49empleadospisoextcorreo="";this.O49empleadospisoextcorreo="";this.Z48empleadospisoextext="";this.O48empleadospisoextext="";this.Z51empleadospisoextusuario="";this.O51empleadospisoextusuario="";this.Z52empleadospisoextfecgre=gx.date.nullDate();this.O52empleadospisoextfecgre=gx.date.nullDate();this.ZV7updateImage="";this.OV7updateImage="";this.ZV6deleteImage="";this.OV6deleteImage="";this.AV5buscar="";this.A46empleadospisoextid=0;this.A47empleadospisoextpiso="";this.A49empleadospisoextcorreo="";this.A48empleadospisoextext="";this.A51empleadospisoextusuario="";this.A52empleadospisoextfecgre=gx.date.nullDate();this.AV7updateImage="";this.AV6deleteImage="";this.Events={e13362_client:["VUPDATEIMAGE.CLICK",!0],e14362_client:["VDELETEIMAGE.CLICK",!0],e11362_client:["ENTER",!0],e16362_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"EMPELADOSPISOGRID_nFirstRecordOnPage",nv:0},{av:"EMPELADOSPISOGRID_nEOF",nv:0},{av:"AV7updateImage",fld:"vUPDATEIMAGE",pic:"",nv:""},{av:"AV6deleteImage",fld:"vDELETEIMAGE",pic:"",nv:""}],[]];this.EvtParms["VUPDATEIMAGE.CLICK"]=[[{av:"A46empleadospisoextid",fld:"EMPLEADOSPISOEXTID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms["VDELETEIMAGE.CLICK"]=[[{av:"A46empleadospisoextid",fld:"EMPLEADOSPISOEXTID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms.ENTER=[[],[]];this.EvtParms["EMPELADOSPISOGRID.LOAD"]=[[],[]];this.EnterCtrl=["BUTTON1"];t.addRefreshingVar({rfrVar:"AV7updateImage",rfrProp:"Value",gxAttId:"Updateimage"});t.addRefreshingVar({rfrVar:"AV6deleteImage",rfrProp:"Value",gxAttId:"Deleteimage"});this.InitStandaloneVars()});gx.createParentObj(detallesempleadospiso)