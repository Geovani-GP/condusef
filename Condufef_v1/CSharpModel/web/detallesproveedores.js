/**@preserve  GeneXus C# 10_3_15-115824 on 2/3/2022 14:38:5.42
*/
gx.evt.autoSkip=!1;gx.define("detallesproveedores",!1,function(){var n,t;this.ServerClass="detallesproveedores";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e13342_client=function(){this.executeServerEvent("VUPDATEIMAGE.CLICK",!0,arguments[0],!1,!1)};this.e14342_client=function(){this.executeServerEvent("VDELETEIMAGE.CLICK",!0,arguments[0],!1,!1)};this.e11342_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e16342_client=function(){this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,5,7,12,13,14,15,16,17,18,19,20,21,22,23,24];this.GXLastCtrlId=24;this.ProveedoresgridContainer=new gx.grid.grid(this,2,"WbpLvl2",11,"Proveedoresgrid","Proveedoresgrid","ProveedoresgridContainer",this.CmpContext,this.IsMasterPage,"detallesproveedores",[],!1,1,!1,!0,0,!1,!1,!1,"",0,"px","Nueva fila",!1,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.ProveedoresgridContainer;t.addSingleLineEdit(2,12,"PROVEEDORESID","ID","","proveedoresid","int",0,"px",9,9,"left",null,[],2,"proveedoresid",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(126,13,"PROVEEDORESNOMBRE","Nombre","","proveedoresnombre","svchar",0,"px",80,80,"left",null,[],126,"proveedoresnombre",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(135,14,"PROVEEDORESRFC","rfc","","proveedoresrfc","svchar",0,"px",13,13,"left",null,[],135,"proveedoresrfc",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(127,15,"PROVEEDORESDIRECCION","Direccion","","proveedoresdireccion","svchar",0,"px",50,50,"left",null,[],127,"proveedoresdireccion",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(128,16,"PROVEEDORESCOLONIA","Colonia","","proveedorescolonia","svchar",0,"px",25,25,"left",null,[],128,"proveedorescolonia",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(129,17,"PROVEEDORESCODIGOPOSTAL","Codigo Postal","","proveedorescodigopostal","svchar",0,"px",5,5,"left",null,[],129,"proveedorescodigopostal",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(130,18,"PROVEEDORESMUNICIPIO","Municipio","","proveedoresmunicipio","svchar",0,"px",25,25,"left",null,[],130,"proveedoresmunicipio",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(131,19,"PROVEEDORESTADO","Estado","","proveedorestado","svchar",0,"px",20,20,"left",null,[],131,"proveedorestado",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(134,20,"PROVEEDORESFAX","Fax","","proveedoresfax","svchar",0,"px",15,15,"left",null,[],134,"proveedoresfax",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(132,21,"PROVEEDORESTELEFONO1","Tel 1","","proveedorestelefono1","int",0,"px",10,10,"right",null,[],132,"proveedorestelefono1",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(133,22,"PROVEEDORESTELEFONO2","Tel 2","","proveedorestelefono2","int",0,"px",10,10,"right",null,[],133,"proveedorestelefono2",!0,0,!1,!1,"Attribute",1,"");t.addBitmap("&Updateimage","vUPDATEIMAGE",23,0,"px",17,"px","e13342_client","","","Image","");t.addBitmap("&Deleteimage","vDELETEIMAGE",24,0,"px",17,"px","e14342_client","","","Image","");this.setGrid(t);n[2]={fld:"TABLE1",grid:0};n[5]={lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vBUSCAR",gxz:"ZV5buscar",gxold:"OV5buscar",gxvar:"AV5buscar",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV5buscar=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5buscar=n)},v2c:function(){gx.fn.setControlValue("vBUSCAR",gx.O.AV5buscar,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV5buscar=this.val())},val:function(){return gx.fn.getControlValue("vBUSCAR")},nac:gx.falseFn};n[7]={fld:"TEXTBLOCK1",format:0,grid:0};n[12]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:11,gxgrid:this.ProveedoresgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESID",gxz:"Z2proveedoresid",gxold:"O2proveedoresid",gxvar:"A2proveedoresid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A2proveedoresid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2proveedoresid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PROVEEDORESID",n||gx.fn.currentGridRowImpl(11),gx.O.A2proveedoresid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A2proveedoresid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PROVEEDORESID",n||gx.fn.currentGridRowImpl(11),".")},nac:gx.falseFn};n[13]={lvl:2,type:"svchar",len:80,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.ProveedoresgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESNOMBRE",gxz:"Z126proveedoresnombre",gxold:"O126proveedoresnombre",gxvar:"A126proveedoresnombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A126proveedoresnombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z126proveedoresnombre=n)},v2c:function(n){gx.fn.setGridControlValue("PROVEEDORESNOMBRE",n||gx.fn.currentGridRowImpl(11),gx.O.A126proveedoresnombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A126proveedoresnombre=this.val())},val:function(n){return gx.fn.getGridControlValue("PROVEEDORESNOMBRE",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};n[14]={lvl:2,type:"svchar",len:13,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.ProveedoresgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESRFC",gxz:"Z135proveedoresrfc",gxold:"O135proveedoresrfc",gxvar:"A135proveedoresrfc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A135proveedoresrfc=n)},v2z:function(n){n!==undefined&&(gx.O.Z135proveedoresrfc=n)},v2c:function(n){gx.fn.setGridControlValue("PROVEEDORESRFC",n||gx.fn.currentGridRowImpl(11),gx.O.A135proveedoresrfc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A135proveedoresrfc=this.val())},val:function(n){return gx.fn.getGridControlValue("PROVEEDORESRFC",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};n[15]={lvl:2,type:"svchar",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.ProveedoresgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESDIRECCION",gxz:"Z127proveedoresdireccion",gxold:"O127proveedoresdireccion",gxvar:"A127proveedoresdireccion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A127proveedoresdireccion=n)},v2z:function(n){n!==undefined&&(gx.O.Z127proveedoresdireccion=n)},v2c:function(n){gx.fn.setGridControlValue("PROVEEDORESDIRECCION",n||gx.fn.currentGridRowImpl(11),gx.O.A127proveedoresdireccion,0)},c2v:function(){this.val()!==undefined&&(gx.O.A127proveedoresdireccion=this.val())},val:function(n){return gx.fn.getGridControlValue("PROVEEDORESDIRECCION",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};n[16]={lvl:2,type:"svchar",len:25,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.ProveedoresgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESCOLONIA",gxz:"Z128proveedorescolonia",gxold:"O128proveedorescolonia",gxvar:"A128proveedorescolonia",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A128proveedorescolonia=n)},v2z:function(n){n!==undefined&&(gx.O.Z128proveedorescolonia=n)},v2c:function(n){gx.fn.setGridControlValue("PROVEEDORESCOLONIA",n||gx.fn.currentGridRowImpl(11),gx.O.A128proveedorescolonia,0)},c2v:function(){this.val()!==undefined&&(gx.O.A128proveedorescolonia=this.val())},val:function(n){return gx.fn.getGridControlValue("PROVEEDORESCOLONIA",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};n[17]={lvl:2,type:"svchar",len:5,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.ProveedoresgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESCODIGOPOSTAL",gxz:"Z129proveedorescodigopostal",gxold:"O129proveedorescodigopostal",gxvar:"A129proveedorescodigopostal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A129proveedorescodigopostal=n)},v2z:function(n){n!==undefined&&(gx.O.Z129proveedorescodigopostal=n)},v2c:function(n){gx.fn.setGridControlValue("PROVEEDORESCODIGOPOSTAL",n||gx.fn.currentGridRowImpl(11),gx.O.A129proveedorescodigopostal,0)},c2v:function(){this.val()!==undefined&&(gx.O.A129proveedorescodigopostal=this.val())},val:function(n){return gx.fn.getGridControlValue("PROVEEDORESCODIGOPOSTAL",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};n[18]={lvl:2,type:"svchar",len:25,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.ProveedoresgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESMUNICIPIO",gxz:"Z130proveedoresmunicipio",gxold:"O130proveedoresmunicipio",gxvar:"A130proveedoresmunicipio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A130proveedoresmunicipio=n)},v2z:function(n){n!==undefined&&(gx.O.Z130proveedoresmunicipio=n)},v2c:function(n){gx.fn.setGridControlValue("PROVEEDORESMUNICIPIO",n||gx.fn.currentGridRowImpl(11),gx.O.A130proveedoresmunicipio,0)},c2v:function(){this.val()!==undefined&&(gx.O.A130proveedoresmunicipio=this.val())},val:function(n){return gx.fn.getGridControlValue("PROVEEDORESMUNICIPIO",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};n[19]={lvl:2,type:"svchar",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.ProveedoresgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESTADO",gxz:"Z131proveedorestado",gxold:"O131proveedorestado",gxvar:"A131proveedorestado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A131proveedorestado=n)},v2z:function(n){n!==undefined&&(gx.O.Z131proveedorestado=n)},v2c:function(n){gx.fn.setGridControlValue("PROVEEDORESTADO",n||gx.fn.currentGridRowImpl(11),gx.O.A131proveedorestado,0)},c2v:function(){this.val()!==undefined&&(gx.O.A131proveedorestado=this.val())},val:function(n){return gx.fn.getGridControlValue("PROVEEDORESTADO",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};n[20]={lvl:2,type:"svchar",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.ProveedoresgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESFAX",gxz:"Z134proveedoresfax",gxold:"O134proveedoresfax",gxvar:"A134proveedoresfax",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A134proveedoresfax=n)},v2z:function(n){n!==undefined&&(gx.O.Z134proveedoresfax=n)},v2c:function(n){gx.fn.setGridControlValue("PROVEEDORESFAX",n||gx.fn.currentGridRowImpl(11),gx.O.A134proveedoresfax,0)},c2v:function(){this.val()!==undefined&&(gx.O.A134proveedoresfax=this.val())},val:function(n){return gx.fn.getGridControlValue("PROVEEDORESFAX",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};n[21]={lvl:2,type:"int",len:10,dec:0,sign:!1,pic:"ZZZZZZZZZ9",ro:1,isacc:0,grid:11,gxgrid:this.ProveedoresgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESTELEFONO1",gxz:"Z132proveedorestelefono1",gxold:"O132proveedorestelefono1",gxvar:"A132proveedorestelefono1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A132proveedorestelefono1=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z132proveedorestelefono1=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PROVEEDORESTELEFONO1",n||gx.fn.currentGridRowImpl(11),gx.O.A132proveedorestelefono1,0)},c2v:function(){this.val()!==undefined&&(gx.O.A132proveedorestelefono1=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PROVEEDORESTELEFONO1",n||gx.fn.currentGridRowImpl(11),".")},nac:gx.falseFn};n[22]={lvl:2,type:"int",len:10,dec:0,sign:!1,pic:"ZZZZZZZZZ9",ro:1,isacc:0,grid:11,gxgrid:this.ProveedoresgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESTELEFONO2",gxz:"Z133proveedorestelefono2",gxold:"O133proveedorestelefono2",gxvar:"A133proveedorestelefono2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A133proveedorestelefono2=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z133proveedorestelefono2=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PROVEEDORESTELEFONO2",n||gx.fn.currentGridRowImpl(11),gx.O.A133proveedorestelefono2,0)},c2v:function(){this.val()!==undefined&&(gx.O.A133proveedorestelefono2=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PROVEEDORESTELEFONO2",n||gx.fn.currentGridRowImpl(11),".")},nac:gx.falseFn};n[23]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.ProveedoresgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"vUPDATEIMAGE",gxz:"ZV7updateImage",gxold:"OV7updateImage",gxvar:"AV7updateImage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV7updateImage=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7updateImage=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATEIMAGE",n||gx.fn.currentGridRowImpl(11),gx.O.AV7updateImage,gx.O.AV10Updateimage_GXI)},c2v:function(){gx.O.AV10Updateimage_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV7updateImage=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATEIMAGE",n||gx.fn.currentGridRowImpl(11))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATEIMAGE_GXI",n||gx.fn.currentGridRowImpl(11))},gxvar_GXI:"AV10Updateimage_GXI",nac:gx.falseFn};n[24]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.ProveedoresgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"vDELETEIMAGE",gxz:"ZV6deleteImage",gxold:"OV6deleteImage",gxvar:"AV6deleteImage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV6deleteImage=n)},v2z:function(n){n!==undefined&&(gx.O.ZV6deleteImage=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETEIMAGE",n||gx.fn.currentGridRowImpl(11),gx.O.AV6deleteImage,gx.O.AV11Deleteimage_GXI)},c2v:function(){gx.O.AV11Deleteimage_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV6deleteImage=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETEIMAGE",n||gx.fn.currentGridRowImpl(11))},val_GXI:function(n){return gx.fn.getGridControlValue("vDELETEIMAGE_GXI",n||gx.fn.currentGridRowImpl(11))},gxvar_GXI:"AV11Deleteimage_GXI",nac:gx.falseFn};this.AV5buscar="";this.ZV5buscar="";this.OV5buscar="";this.Z2proveedoresid=0;this.O2proveedoresid=0;this.Z126proveedoresnombre="";this.O126proveedoresnombre="";this.Z135proveedoresrfc="";this.O135proveedoresrfc="";this.Z127proveedoresdireccion="";this.O127proveedoresdireccion="";this.Z128proveedorescolonia="";this.O128proveedorescolonia="";this.Z129proveedorescodigopostal="";this.O129proveedorescodigopostal="";this.Z130proveedoresmunicipio="";this.O130proveedoresmunicipio="";this.Z131proveedorestado="";this.O131proveedorestado="";this.Z134proveedoresfax="";this.O134proveedoresfax="";this.Z132proveedorestelefono1=0;this.O132proveedorestelefono1=0;this.Z133proveedorestelefono2=0;this.O133proveedorestelefono2=0;this.ZV7updateImage="";this.OV7updateImage="";this.ZV6deleteImage="";this.OV6deleteImage="";this.AV5buscar="";this.A2proveedoresid=0;this.A126proveedoresnombre="";this.A135proveedoresrfc="";this.A127proveedoresdireccion="";this.A128proveedorescolonia="";this.A129proveedorescodigopostal="";this.A130proveedoresmunicipio="";this.A131proveedorestado="";this.A134proveedoresfax="";this.A132proveedorestelefono1=0;this.A133proveedorestelefono2=0;this.AV7updateImage="";this.AV6deleteImage="";this.Events={e13342_client:["VUPDATEIMAGE.CLICK",!0],e14342_client:["VDELETEIMAGE.CLICK",!0],e11342_client:["ENTER",!0],e16342_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"PROVEEDORESGRID_nFirstRecordOnPage",nv:0},{av:"PROVEEDORESGRID_nEOF",nv:0},{av:"AV7updateImage",fld:"vUPDATEIMAGE",pic:"",nv:""},{av:"AV6deleteImage",fld:"vDELETEIMAGE",pic:"",nv:""}],[]];this.EvtParms["VUPDATEIMAGE.CLICK"]=[[{av:"A2proveedoresid",fld:"PROVEEDORESID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms["VDELETEIMAGE.CLICK"]=[[{av:"A2proveedoresid",fld:"PROVEEDORESID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms.ENTER=[[],[]];this.EvtParms["PROVEEDORESGRID.LOAD"]=[[],[]];this.EnterCtrl=["BUTTON1"];t.addRefreshingVar({rfrVar:"AV7updateImage",rfrProp:"Value",gxAttId:"Updateimage"});t.addRefreshingVar({rfrVar:"AV6deleteImage",rfrProp:"Value",gxAttId:"Deleteimage"});this.InitStandaloneVars()});gx.createParentObj(detallesproveedores)