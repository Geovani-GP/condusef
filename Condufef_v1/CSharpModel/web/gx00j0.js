/**@preserve  GeneXus C# 10_3_15-115824 on 1/30/2022 23:38:29.97
*/
gx.evt.autoSkip=!1;gx.define("gx00j0",!1,function(){var n,t;this.ServerClass="gx00j0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV11pmodelosid=gx.fn.getIntegerValue("vPMODELOSID",".")};this.e161z1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e111z1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MODELOSIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MODELOSIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMODELOSID","Visible",!0)):(gx.fn.setCtrlProperty("MODELOSIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMODELOSID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MODELOSIDFILTERCONTAINER","Class")',ctrl:"MODELOSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODELOSID","Visible")',ctrl:"vCMODELOSID",prop:"Visible"}])};this.e121z1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MODELOSDSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MODELOSDSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMODELOSDSC","Visible",!0)):(gx.fn.setCtrlProperty("MODELOSDSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMODELOSDSC","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MODELOSDSCFILTERCONTAINER","Class")',ctrl:"MODELOSDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODELOSDSC","Visible")',ctrl:"vCMODELOSDSC",prop:"Visible"}])};this.e131z1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MODELOSUSUARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MODELOSUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMODELOSUSUARIO","Visible",!0)):(gx.fn.setCtrlProperty("MODELOSUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMODELOSUSUARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MODELOSUSUARIOFILTERCONTAINER","Class")',ctrl:"MODELOSUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODELOSUSUARIO","Visible")',ctrl:"vCMODELOSUSUARIO",prop:"Visible"}])};this.e141z1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MODELOSFECREGFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("MODELOSFECREGFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("MODELOSFECREGFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MODELOSFECREGFILTERCONTAINER","Class")',ctrl:"MODELOSFECREGFILTERCONTAINER",prop:"Class"}])};this.e151z1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MODELOSFECULTACTFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("MODELOSFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("MODELOSFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MODELOSFECULTACTFILTERCONTAINER","Class")',ctrl:"MODELOSFECULTACTFILTERCONTAINER",prop:"Class"}])};this.e191z2_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e201z1_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,62,63,65,66,67,68,69,70];this.GXLastCtrlId=70;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",64,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00j0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",65,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(15,66,"MODELOSID","productoid","","modelosid","int",0,"px",9,9,"right",null,[],15,"modelosid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(116,67,"MODELOSDSC","modelosdsc","","modelosdsc","svchar",0,"px",100,80,"left",null,[],116,"modelosdsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(117,68,"MODELOSUSUARIO","modelosusuario","","modelosusuario","svchar",0,"px",15,15,"left",null,[],117,"modelosusuario",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"MODELOSIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLMODELOSIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMODELOSID",gxz:"ZV6cmodelosid",gxold:"OV6cmodelosid",gxvar:"AV6cmodelosid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cmodelosid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cmodelosid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMODELOSID",gx.O.AV6cmodelosid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cmodelosid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMODELOSID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"MODELOSDSCFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLMODELOSDSCFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMODELOSDSC",gxz:"ZV7cmodelosdsc",gxold:"OV7cmodelosdsc",gxvar:"AV7cmodelosdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cmodelosdsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cmodelosdsc=n)},v2c:function(){gx.fn.setControlValue("vCMODELOSDSC",gx.O.AV7cmodelosdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cmodelosdsc=this.val())},val:function(){return gx.fn.getControlValue("vCMODELOSDSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"MODELOSUSUARIOFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLMODELOSUSUARIOFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMODELOSUSUARIO",gxz:"ZV8cmodelosusuario",gxold:"OV8cmodelosusuario",gxvar:"AV8cmodelosusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cmodelosusuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cmodelosusuario=n)},v2c:function(){gx.fn.setControlValue("vCMODELOSUSUARIO",gx.O.AV8cmodelosusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cmodelosusuario=this.val())},val:function(){return gx.fn.getControlValue("vCMODELOSUSUARIO")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"MODELOSFECREGFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLMODELOSFECREGFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMODELOSFECREG",gxz:"ZV9cmodelosfecreg",gxold:"OV9cmodelosfecreg",gxvar:"AV9cmodelosfecreg",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cmodelosfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9cmodelosfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCMODELOSFECREG",gx.O.AV9cmodelosfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cmodelosfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCMODELOSFECREG")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"MODELOSFECULTACTFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLMODELOSFECULTACTFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMODELOSFECULTACT",gxz:"ZV10cmodelosfecultact",gxold:"OV10cmodelosfecultact",gxvar:"AV10cmodelosfecultact",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cmodelosfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10cmodelosfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCMODELOSFECULTACT",gx.O.AV10cmodelosfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cmodelosfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCMODELOSFECULTACT")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"GRIDTABLE",grid:0};n[59]={fld:"",grid:0};n[60]={fld:"",grid:0};n[62]={fld:"",grid:0};n[63]={fld:"",grid:0};n[65]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64),gx.O.AV5LinkSelection,gx.O.AV15Linkselection_GXI)},c2v:function(){gx.O.AV15Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(64))},gxvar_GXI:"AV15Linkselection_GXI",nac:gx.falseFn};n[66]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MODELOSID",gxz:"Z15modelosid",gxold:"O15modelosid",gxvar:"A15modelosid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A15modelosid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z15modelosid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("MODELOSID",n||gx.fn.currentGridRowImpl(64),gx.O.A15modelosid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A15modelosid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("MODELOSID",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[67]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MODELOSDSC",gxz:"Z116modelosdsc",gxold:"O116modelosdsc",gxvar:"A116modelosdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A116modelosdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z116modelosdsc=n)},v2c:function(n){gx.fn.setGridControlValue("MODELOSDSC",n||gx.fn.currentGridRowImpl(64),gx.O.A116modelosdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A116modelosdsc=this.val())},val:function(n){return gx.fn.getGridControlValue("MODELOSDSC",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[68]={lvl:2,type:"svchar",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MODELOSUSUARIO",gxz:"Z117modelosusuario",gxold:"O117modelosusuario",gxvar:"A117modelosusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A117modelosusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z117modelosusuario=n)},v2c:function(n){gx.fn.setGridControlValue("MODELOSUSUARIO",n||gx.fn.currentGridRowImpl(64),gx.O.A117modelosusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A117modelosusuario=this.val())},val:function(n){return gx.fn.getGridControlValue("MODELOSUSUARIO",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[69]={fld:"",grid:0};n[70]={fld:"",grid:0};this.AV6cmodelosid=0;this.ZV6cmodelosid=0;this.OV6cmodelosid=0;this.AV7cmodelosdsc="";this.ZV7cmodelosdsc="";this.OV7cmodelosdsc="";this.AV8cmodelosusuario="";this.ZV8cmodelosusuario="";this.OV8cmodelosusuario="";this.AV9cmodelosfecreg=gx.date.nullDate();this.ZV9cmodelosfecreg=gx.date.nullDate();this.OV9cmodelosfecreg=gx.date.nullDate();this.AV10cmodelosfecultact=gx.date.nullDate();this.ZV10cmodelosfecultact=gx.date.nullDate();this.OV10cmodelosfecultact=gx.date.nullDate();this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z15modelosid=0;this.O15modelosid=0;this.Z116modelosdsc="";this.O116modelosdsc="";this.Z117modelosusuario="";this.O117modelosusuario="";this.AV6cmodelosid=0;this.AV7cmodelosdsc="";this.AV8cmodelosusuario="";this.AV9cmodelosfecreg=gx.date.nullDate();this.AV10cmodelosfecultact=gx.date.nullDate();this.AV11pmodelosid=0;this.A119modelosfecultact=gx.date.nullDate();this.A118modelosfecreg=gx.date.nullDate();this.AV5LinkSelection="";this.A15modelosid=0;this.A116modelosdsc="";this.A117modelosusuario="";this.Events={e191z2_client:["ENTER",!0],e201z1_client:["CANCEL",!0],e161z1_client:["'TOGGLE'",!1],e111z1_client:["LBLMODELOSIDFILTER.CLICK",!1],e121z1_client:["LBLMODELOSDSCFILTER.CLICK",!1],e131z1_client:["LBLMODELOSUSUARIOFILTER.CLICK",!1],e141z1_client:["LBLMODELOSFECREGFILTER.CLICK",!1],e151z1_client:["LBLMODELOSFECULTACTFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmodelosid",fld:"vCMODELOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cmodelosdsc",fld:"vCMODELOSDSC",pic:"",nv:""},{av:"AV8cmodelosusuario",fld:"vCMODELOSUSUARIO",pic:"",nv:""},{av:"AV9cmodelosfecreg",fld:"vCMODELOSFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10cmodelosfecultact",fld:"vCMODELOSFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLMODELOSIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MODELOSIDFILTERCONTAINER","Class")',ctrl:"MODELOSIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MODELOSIDFILTERCONTAINER","Class")',ctrl:"MODELOSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODELOSID","Visible")',ctrl:"vCMODELOSID",prop:"Visible"}]];this.EvtParms["LBLMODELOSDSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MODELOSDSCFILTERCONTAINER","Class")',ctrl:"MODELOSDSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MODELOSDSCFILTERCONTAINER","Class")',ctrl:"MODELOSDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODELOSDSC","Visible")',ctrl:"vCMODELOSDSC",prop:"Visible"}]];this.EvtParms["LBLMODELOSUSUARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MODELOSUSUARIOFILTERCONTAINER","Class")',ctrl:"MODELOSUSUARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MODELOSUSUARIOFILTERCONTAINER","Class")',ctrl:"MODELOSUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODELOSUSUARIO","Visible")',ctrl:"vCMODELOSUSUARIO",prop:"Visible"}]];this.EvtParms["LBLMODELOSFECREGFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MODELOSFECREGFILTERCONTAINER","Class")',ctrl:"MODELOSFECREGFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MODELOSFECREGFILTERCONTAINER","Class")',ctrl:"MODELOSFECREGFILTERCONTAINER",prop:"Class"}]];this.EvtParms["LBLMODELOSFECULTACTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MODELOSFECULTACTFILTERCONTAINER","Class")',ctrl:"MODELOSFECULTACTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MODELOSFECULTACTFILTERCONTAINER","Class")',ctrl:"MODELOSFECULTACTFILTERCONTAINER",prop:"Class"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A15modelosid",fld:"MODELOSID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV11pmodelosid",fld:"vPMODELOSID",pic:"ZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmodelosid",fld:"vCMODELOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cmodelosdsc",fld:"vCMODELOSDSC",pic:"",nv:""},{av:"AV8cmodelosusuario",fld:"vCMODELOSUSUARIO",pic:"",nv:""},{av:"AV9cmodelosfecreg",fld:"vCMODELOSFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10cmodelosfecultact",fld:"vCMODELOSFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmodelosid",fld:"vCMODELOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cmodelosdsc",fld:"vCMODELOSDSC",pic:"",nv:""},{av:"AV8cmodelosusuario",fld:"vCMODELOSUSUARIO",pic:"",nv:""},{av:"AV9cmodelosfecreg",fld:"vCMODELOSFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10cmodelosfecultact",fld:"vCMODELOSFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmodelosid",fld:"vCMODELOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cmodelosdsc",fld:"vCMODELOSDSC",pic:"",nv:""},{av:"AV8cmodelosusuario",fld:"vCMODELOSUSUARIO",pic:"",nv:""},{av:"AV9cmodelosfecreg",fld:"vCMODELOSFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10cmodelosfecultact",fld:"vCMODELOSFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmodelosid",fld:"vCMODELOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cmodelosdsc",fld:"vCMODELOSDSC",pic:"",nv:""},{av:"AV8cmodelosusuario",fld:"vCMODELOSUSUARIO",pic:"",nv:""},{av:"AV9cmodelosfecreg",fld:"vCMODELOSFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10cmodelosfecultact",fld:"vCMODELOSFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.setVCMap("AV11pmodelosid","vPMODELOSID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);this.InitStandaloneVars()});gx.createParentObj(gx00j0)