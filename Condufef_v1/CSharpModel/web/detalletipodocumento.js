/**@preserve  GeneXus C# 10_3_15-115824 on 2/2/2022 13:43:3.61
*/
gx.evt.autoSkip=!1;gx.define("detalletipodocumento",!1,function(){var t,n;this.ServerClass="detalletipodocumento";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e132v2_client=function(){this.executeServerEvent("VUPDATEIMAGE.CLICK",!0,arguments[0],!1,!1)};this.e142v2_client=function(){this.executeServerEvent("VDELETEIMAGE.CLICK",!0,arguments[0],!1,!1)};this.e112v2_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e162v2_client=function(){this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,5,7,13,14,15,16];this.GXLastCtrlId=16;this.TipodocumentogridContainer=new gx.grid.grid(this,2,"WbpLvl2",12,"Tipodocumentogrid","Tipodocumentogrid","TipodocumentogridContainer",this.CmpContext,this.IsMasterPage,"detalletipodocumento",[],!1,1,!1,!0,0,!1,!1,!1,"",0,"px","Nueva fila",!1,!1,!1,null,null,!1,"",!1,[1,1,1,1]);n=this.TipodocumentogridContainer;n.addSingleLineEdit(26,13,"TIPODOCUMENTOID","tipodocumentoid","","tipodocumentoid","int",0,"px",9,9,"left",null,[],26,"tipodocumentoid",!0,0,!1,!1,"Attribute",1,"");n.addSingleLineEdit(79,14,"TIPODOCUMENTODSC","tipodocumentodsc","","tipodocumentodsc","svchar",0,"px",100,80,"left",null,[],79,"tipodocumentodsc",!0,0,!1,!1,"Attribute",1,"");n.addBitmap("&Updateimage","vUPDATEIMAGE",15,0,"px",17,"px","e132v2_client","","update Image","Image","");n.addBitmap("&Deleteimage","vDELETEIMAGE",16,0,"px",17,"px","e142v2_client","","delete Image","Image","");this.setGrid(n);t[2]={fld:"TABLE1",grid:0};t[5]={lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.TipodocumentogridContainer],fld:"vBUSCAR",gxz:"ZV5buscar",gxold:"OV5buscar",gxvar:"AV5buscar",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV5buscar=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5buscar=n)},v2c:function(){gx.fn.setControlValue("vBUSCAR",gx.O.AV5buscar,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV5buscar=this.val())},val:function(){return gx.fn.getControlValue("vBUSCAR")},nac:gx.falseFn};t[7]={fld:"TEXTBLOCK1",format:0,grid:0};t[13]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:12,gxgrid:this.TipodocumentogridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TIPODOCUMENTOID",gxz:"Z26tipodocumentoid",gxold:"O26tipodocumentoid",gxvar:"A26tipodocumentoid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A26tipodocumentoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z26tipodocumentoid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("TIPODOCUMENTOID",n||gx.fn.currentGridRowImpl(12),gx.O.A26tipodocumentoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A26tipodocumentoid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("TIPODOCUMENTOID",n||gx.fn.currentGridRowImpl(12),".")},nac:gx.falseFn};t[14]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.TipodocumentogridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TIPODOCUMENTODSC",gxz:"Z79tipodocumentodsc",gxold:"O79tipodocumentodsc",gxvar:"A79tipodocumentodsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A79tipodocumentodsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z79tipodocumentodsc=n)},v2c:function(n){gx.fn.setGridControlValue("TIPODOCUMENTODSC",n||gx.fn.currentGridRowImpl(12),gx.O.A79tipodocumentodsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A79tipodocumentodsc=this.val())},val:function(n){return gx.fn.getGridControlValue("TIPODOCUMENTODSC",n||gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};t[15]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.TipodocumentogridContainer,fnc:null,isvalid:null,rgrid:[],fld:"vUPDATEIMAGE",gxz:"ZV7updateImage",gxold:"OV7updateImage",gxvar:"AV7updateImage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV7updateImage=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7updateImage=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATEIMAGE",n||gx.fn.currentGridRowImpl(12),gx.O.AV7updateImage,gx.O.AV10Updateimage_GXI)},c2v:function(){gx.O.AV10Updateimage_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV7updateImage=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATEIMAGE",n||gx.fn.currentGridRowImpl(12))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATEIMAGE_GXI",n||gx.fn.currentGridRowImpl(12))},gxvar_GXI:"AV10Updateimage_GXI",nac:gx.falseFn};t[16]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.TipodocumentogridContainer,fnc:null,isvalid:null,rgrid:[],fld:"vDELETEIMAGE",gxz:"ZV6deleteImage",gxold:"OV6deleteImage",gxvar:"AV6deleteImage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV6deleteImage=n)},v2z:function(n){n!==undefined&&(gx.O.ZV6deleteImage=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETEIMAGE",n||gx.fn.currentGridRowImpl(12),gx.O.AV6deleteImage,gx.O.AV11Deleteimage_GXI)},c2v:function(){gx.O.AV11Deleteimage_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV6deleteImage=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETEIMAGE",n||gx.fn.currentGridRowImpl(12))},val_GXI:function(n){return gx.fn.getGridControlValue("vDELETEIMAGE_GXI",n||gx.fn.currentGridRowImpl(12))},gxvar_GXI:"AV11Deleteimage_GXI",nac:gx.falseFn};this.AV5buscar="";this.ZV5buscar="";this.OV5buscar="";this.Z26tipodocumentoid=0;this.O26tipodocumentoid=0;this.Z79tipodocumentodsc="";this.O79tipodocumentodsc="";this.ZV7updateImage="";this.OV7updateImage="";this.ZV6deleteImage="";this.OV6deleteImage="";this.AV5buscar="";this.A26tipodocumentoid=0;this.A79tipodocumentodsc="";this.AV7updateImage="";this.AV6deleteImage="";this.Events={e132v2_client:["VUPDATEIMAGE.CLICK",!0],e142v2_client:["VDELETEIMAGE.CLICK",!0],e112v2_client:["ENTER",!0],e162v2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"TIPODOCUMENTOGRID_nFirstRecordOnPage",nv:0},{av:"TIPODOCUMENTOGRID_nEOF",nv:0},{av:"AV5buscar",fld:"vBUSCAR",pic:"",nv:""},{av:"AV7updateImage",fld:"vUPDATEIMAGE",pic:"",nv:""},{av:"AV6deleteImage",fld:"vDELETEIMAGE",pic:"",nv:""}],[]];this.EvtParms["VUPDATEIMAGE.CLICK"]=[[{av:"A26tipodocumentoid",fld:"TIPODOCUMENTOID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms["VDELETEIMAGE.CLICK"]=[[{av:"A26tipodocumentoid",fld:"TIPODOCUMENTOID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms.ENTER=[[],[]];this.EvtParms["TIPODOCUMENTOGRID.LOAD"]=[[],[]];this.EnterCtrl=["BUTTON1"];n.addRefreshingVar(this.GXValidFnc[5]);n.addRefreshingVar({rfrVar:"AV7updateImage",rfrProp:"Value",gxAttId:"Updateimage"});n.addRefreshingVar({rfrVar:"AV6deleteImage",rfrProp:"Value",gxAttId:"Deleteimage"});this.InitStandaloneVars()});gx.createParentObj(detalletipodocumento)