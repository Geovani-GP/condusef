/**@preserve  GeneXus C# 10_3_15-115824 on 1/23/2022 3:49:39.0
*/
gx.evt.autoSkip=!1;gx.define("gx00e0",!1,function(){var n,t;this.ServerClass="gx00e0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV11pcambsid=gx.fn.getIntegerValue("vPCAMBSID",".")};this.e160j1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e110j1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("CAMBSIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CAMBSIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCAMBSID","Visible",!0)):(gx.fn.setCtrlProperty("CAMBSIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCAMBSID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CAMBSIDFILTERCONTAINER","Class")',ctrl:"CAMBSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCAMBSID","Visible")',ctrl:"vCCAMBSID",prop:"Visible"}])};this.e120j1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("CAMBSDSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CAMBSDSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCAMBSDSC","Visible",!0)):(gx.fn.setCtrlProperty("CAMBSDSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCAMBSDSC","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CAMBSDSCFILTERCONTAINER","Class")',ctrl:"CAMBSDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCAMBSDSC","Visible")',ctrl:"vCCAMBSDSC",prop:"Visible"}])};this.e130j1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("CAMBSUSUARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CAMBSUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCAMBSUSUARIO","Visible",!0)):(gx.fn.setCtrlProperty("CAMBSUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCAMBSUSUARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CAMBSUSUARIOFILTERCONTAINER","Class")',ctrl:"CAMBSUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCAMBSUSUARIO","Visible")',ctrl:"vCCAMBSUSUARIO",prop:"Visible"}])};this.e140j1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("CAMBSFECREGFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("CAMBSFECREGFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("CAMBSFECREGFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CAMBSFECREGFILTERCONTAINER","Class")',ctrl:"CAMBSFECREGFILTERCONTAINER",prop:"Class"}])};this.e150j1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("CAMBSFECULTACTFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("CAMBSFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("CAMBSFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CAMBSFECULTACTFILTERCONTAINER","Class")',ctrl:"CAMBSFECULTACTFILTERCONTAINER",prop:"Class"}])};this.e190j2_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e200j1_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,62,63,65,66,67,68,69,70];this.GXLastCtrlId=70;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",64,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00e0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",65,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(25,66,"CAMBSID","cambsid","","cambsid","int",0,"px",9,9,"right",null,[],25,"cambsid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(83,67,"CAMBSDSC","cambsdsc","","cambsdsc","svchar",0,"px",100,80,"left",null,[],83,"cambsdsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(84,68,"CAMBSUSUARIO","cambsusuario","","cambsusuario","svchar",0,"px",15,15,"left",null,[],84,"cambsusuario",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"CAMBSIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLCAMBSIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCAMBSID",gxz:"ZV6ccambsid",gxold:"OV6ccambsid",gxvar:"AV6ccambsid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6ccambsid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6ccambsid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCCAMBSID",gx.O.AV6ccambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6ccambsid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCCAMBSID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"CAMBSDSCFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLCAMBSDSCFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCAMBSDSC",gxz:"ZV7ccambsdsc",gxold:"OV7ccambsdsc",gxvar:"AV7ccambsdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7ccambsdsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7ccambsdsc=n)},v2c:function(){gx.fn.setControlValue("vCCAMBSDSC",gx.O.AV7ccambsdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7ccambsdsc=this.val())},val:function(){return gx.fn.getControlValue("vCCAMBSDSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"CAMBSUSUARIOFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLCAMBSUSUARIOFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCAMBSUSUARIO",gxz:"ZV8ccambsusuario",gxold:"OV8ccambsusuario",gxvar:"AV8ccambsusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8ccambsusuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8ccambsusuario=n)},v2c:function(){gx.fn.setControlValue("vCCAMBSUSUARIO",gx.O.AV8ccambsusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8ccambsusuario=this.val())},val:function(){return gx.fn.getControlValue("vCCAMBSUSUARIO")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"CAMBSFECREGFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLCAMBSFECREGFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCAMBSFECREG",gxz:"ZV9ccambsfecreg",gxold:"OV9ccambsfecreg",gxvar:"AV9ccambsfecreg",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9ccambsfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9ccambsfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCCAMBSFECREG",gx.O.AV9ccambsfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9ccambsfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCCAMBSFECREG")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"CAMBSFECULTACTFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLCAMBSFECULTACTFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCAMBSFECULTACT",gxz:"ZV10ccambsfecultact",gxold:"OV10ccambsfecultact",gxvar:"AV10ccambsfecultact",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10ccambsfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10ccambsfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCCAMBSFECULTACT",gx.O.AV10ccambsfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10ccambsfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCCAMBSFECULTACT")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"GRIDTABLE",grid:0};n[59]={fld:"",grid:0};n[60]={fld:"",grid:0};n[62]={fld:"",grid:0};n[63]={fld:"",grid:0};n[65]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64),gx.O.AV5LinkSelection,gx.O.AV15Linkselection_GXI)},c2v:function(){gx.O.AV15Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(64))},gxvar_GXI:"AV15Linkselection_GXI",nac:gx.falseFn};n[66]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CAMBSID",gxz:"Z25cambsid",gxold:"O25cambsid",gxvar:"A25cambsid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A25cambsid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z25cambsid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CAMBSID",n||gx.fn.currentGridRowImpl(64),gx.O.A25cambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A25cambsid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CAMBSID",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[67]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CAMBSDSC",gxz:"Z83cambsdsc",gxold:"O83cambsdsc",gxvar:"A83cambsdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A83cambsdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z83cambsdsc=n)},v2c:function(n){gx.fn.setGridControlValue("CAMBSDSC",n||gx.fn.currentGridRowImpl(64),gx.O.A83cambsdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A83cambsdsc=this.val())},val:function(n){return gx.fn.getGridControlValue("CAMBSDSC",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[68]={lvl:2,type:"svchar",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CAMBSUSUARIO",gxz:"Z84cambsusuario",gxold:"O84cambsusuario",gxvar:"A84cambsusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A84cambsusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z84cambsusuario=n)},v2c:function(n){gx.fn.setGridControlValue("CAMBSUSUARIO",n||gx.fn.currentGridRowImpl(64),gx.O.A84cambsusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A84cambsusuario=this.val())},val:function(n){return gx.fn.getGridControlValue("CAMBSUSUARIO",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[69]={fld:"",grid:0};n[70]={fld:"",grid:0};this.AV6ccambsid=0;this.ZV6ccambsid=0;this.OV6ccambsid=0;this.AV7ccambsdsc="";this.ZV7ccambsdsc="";this.OV7ccambsdsc="";this.AV8ccambsusuario="";this.ZV8ccambsusuario="";this.OV8ccambsusuario="";this.AV9ccambsfecreg=gx.date.nullDate();this.ZV9ccambsfecreg=gx.date.nullDate();this.OV9ccambsfecreg=gx.date.nullDate();this.AV10ccambsfecultact=gx.date.nullDate();this.ZV10ccambsfecultact=gx.date.nullDate();this.OV10ccambsfecultact=gx.date.nullDate();this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z25cambsid=0;this.O25cambsid=0;this.Z83cambsdsc="";this.O83cambsdsc="";this.Z84cambsusuario="";this.O84cambsusuario="";this.AV6ccambsid=0;this.AV7ccambsdsc="";this.AV8ccambsusuario="";this.AV9ccambsfecreg=gx.date.nullDate();this.AV10ccambsfecultact=gx.date.nullDate();this.AV11pcambsid=0;this.A86cambsfecultact=gx.date.nullDate();this.A85cambsfecreg=gx.date.nullDate();this.AV5LinkSelection="";this.A25cambsid=0;this.A83cambsdsc="";this.A84cambsusuario="";this.Events={e190j2_client:["ENTER",!0],e200j1_client:["CANCEL",!0],e160j1_client:["'TOGGLE'",!1],e110j1_client:["LBLCAMBSIDFILTER.CLICK",!1],e120j1_client:["LBLCAMBSDSCFILTER.CLICK",!1],e130j1_client:["LBLCAMBSUSUARIOFILTER.CLICK",!1],e140j1_client:["LBLCAMBSFECREGFILTER.CLICK",!1],e150j1_client:["LBLCAMBSFECULTACTFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6ccambsid",fld:"vCCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7ccambsdsc",fld:"vCCAMBSDSC",pic:"",nv:""},{av:"AV8ccambsusuario",fld:"vCCAMBSUSUARIO",pic:"",nv:""},{av:"AV9ccambsfecreg",fld:"vCCAMBSFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10ccambsfecultact",fld:"vCCAMBSFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLCAMBSIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CAMBSIDFILTERCONTAINER","Class")',ctrl:"CAMBSIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CAMBSIDFILTERCONTAINER","Class")',ctrl:"CAMBSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCAMBSID","Visible")',ctrl:"vCCAMBSID",prop:"Visible"}]];this.EvtParms["LBLCAMBSDSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CAMBSDSCFILTERCONTAINER","Class")',ctrl:"CAMBSDSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CAMBSDSCFILTERCONTAINER","Class")',ctrl:"CAMBSDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCAMBSDSC","Visible")',ctrl:"vCCAMBSDSC",prop:"Visible"}]];this.EvtParms["LBLCAMBSUSUARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CAMBSUSUARIOFILTERCONTAINER","Class")',ctrl:"CAMBSUSUARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CAMBSUSUARIOFILTERCONTAINER","Class")',ctrl:"CAMBSUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCAMBSUSUARIO","Visible")',ctrl:"vCCAMBSUSUARIO",prop:"Visible"}]];this.EvtParms["LBLCAMBSFECREGFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CAMBSFECREGFILTERCONTAINER","Class")',ctrl:"CAMBSFECREGFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CAMBSFECREGFILTERCONTAINER","Class")',ctrl:"CAMBSFECREGFILTERCONTAINER",prop:"Class"}]];this.EvtParms["LBLCAMBSFECULTACTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CAMBSFECULTACTFILTERCONTAINER","Class")',ctrl:"CAMBSFECULTACTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CAMBSFECULTACTFILTERCONTAINER","Class")',ctrl:"CAMBSFECULTACTFILTERCONTAINER",prop:"Class"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A25cambsid",fld:"CAMBSID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV11pcambsid",fld:"vPCAMBSID",pic:"ZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6ccambsid",fld:"vCCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7ccambsdsc",fld:"vCCAMBSDSC",pic:"",nv:""},{av:"AV8ccambsusuario",fld:"vCCAMBSUSUARIO",pic:"",nv:""},{av:"AV9ccambsfecreg",fld:"vCCAMBSFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10ccambsfecultact",fld:"vCCAMBSFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6ccambsid",fld:"vCCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7ccambsdsc",fld:"vCCAMBSDSC",pic:"",nv:""},{av:"AV8ccambsusuario",fld:"vCCAMBSUSUARIO",pic:"",nv:""},{av:"AV9ccambsfecreg",fld:"vCCAMBSFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10ccambsfecultact",fld:"vCCAMBSFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6ccambsid",fld:"vCCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7ccambsdsc",fld:"vCCAMBSDSC",pic:"",nv:""},{av:"AV8ccambsusuario",fld:"vCCAMBSUSUARIO",pic:"",nv:""},{av:"AV9ccambsfecreg",fld:"vCCAMBSFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10ccambsfecultact",fld:"vCCAMBSFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6ccambsid",fld:"vCCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7ccambsdsc",fld:"vCCAMBSDSC",pic:"",nv:""},{av:"AV8ccambsusuario",fld:"vCCAMBSUSUARIO",pic:"",nv:""},{av:"AV9ccambsfecreg",fld:"vCCAMBSFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10ccambsfecultact",fld:"vCCAMBSFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.setVCMap("AV11pcambsid","vPCAMBSID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);this.InitStandaloneVars()});gx.createParentObj(gx00e0)