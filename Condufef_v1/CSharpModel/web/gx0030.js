/**@preserve  GeneXus C# 10_3_15-115824 on 2/5/2022 0:54:44.32
*/
gx.evt.autoSkip=!1;gx.define("gx0030",!1,function(){var n,t;this.ServerClass="gx0030";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV11pmesesid=gx.fn.getIntegerValue("vPMESESID",".")};this.e161s1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e111s1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MESESIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MESESIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMESESID","Visible",!0)):(gx.fn.setCtrlProperty("MESESIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMESESID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MESESIDFILTERCONTAINER","Class")',ctrl:"MESESIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMESESID","Visible")',ctrl:"vCMESESID",prop:"Visible"}])};this.e121s1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MESESANIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MESESANIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMESESANIO","Visible",!0)):(gx.fn.setCtrlProperty("MESESANIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMESESANIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MESESANIOFILTERCONTAINER","Class")',ctrl:"MESESANIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMESESANIO","Visible")',ctrl:"vCMESESANIO",prop:"Visible"}])};this.e131s1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MESESUSUARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MESESUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMESESUSUARIO","Visible",!0)):(gx.fn.setCtrlProperty("MESESUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMESESUSUARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MESESUSUARIOFILTERCONTAINER","Class")',ctrl:"MESESUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMESESUSUARIO","Visible")',ctrl:"vCMESESUSUARIO",prop:"Visible"}])};this.e141s1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MESESFECGREFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("MESESFECGREFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("MESESFECGREFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MESESFECGREFILTERCONTAINER","Class")',ctrl:"MESESFECGREFILTERCONTAINER",prop:"Class"}])};this.e151s1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MESESFEACTFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("MESESFEACTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("MESESFEACTFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MESESFEACTFILTERCONTAINER","Class")',ctrl:"MESESFEACTFILTERCONTAINER",prop:"Class"}])};this.e191s2_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e201s1_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,62,63,65,66,67,68,69,70,71,72];this.GXLastCtrlId=72;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",64,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0030",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",65,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(11,66,"MESESID","mesesid","","mesesid","int",0,"px",9,9,"right",null,[],11,"mesesid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(61,67,"MESESANIO","mesesanio","","mesesanio","svchar",0,"px",5,5,"left",null,[],61,"mesesanio",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(62,68,"MESESUSUARIO","mesesusuario","","mesesusuario","svchar",0,"px",15,15,"left",null,[],62,"mesesusuario",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(63,69,"MESESFECGRE","mesesfecgre","","mesesfecgre","dtime",0,"px",19,19,"right",null,[],63,"mesesfecgre",!0,8,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(64,70,"MESESFEACT","mesesfeact","","mesesfeact","dtime",0,"px",19,19,"right",null,[],64,"mesesfeact",!0,8,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"MESESIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLMESESIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMESESID",gxz:"ZV6cmesesid",gxold:"OV6cmesesid",gxvar:"AV6cmesesid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cmesesid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cmesesid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMESESID",gx.O.AV6cmesesid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cmesesid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMESESID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"MESESANIOFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLMESESANIOFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:5,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMESESANIO",gxz:"ZV7cmesesanio",gxold:"OV7cmesesanio",gxvar:"AV7cmesesanio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cmesesanio=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cmesesanio=n)},v2c:function(){gx.fn.setControlValue("vCMESESANIO",gx.O.AV7cmesesanio,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cmesesanio=this.val())},val:function(){return gx.fn.getControlValue("vCMESESANIO")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"MESESUSUARIOFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLMESESUSUARIOFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMESESUSUARIO",gxz:"ZV8cmesesusuario",gxold:"OV8cmesesusuario",gxvar:"AV8cmesesusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cmesesusuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cmesesusuario=n)},v2c:function(){gx.fn.setControlValue("vCMESESUSUARIO",gx.O.AV8cmesesusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cmesesusuario=this.val())},val:function(){return gx.fn.getControlValue("vCMESESUSUARIO")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"MESESFECGREFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLMESESFECGREFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMESESFECGRE",gxz:"ZV9cmesesfecgre",gxold:"OV9cmesesfecgre",gxvar:"AV9cmesesfecgre",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cmesesfecgre=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9cmesesfecgre=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCMESESFECGRE",gx.O.AV9cmesesfecgre,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cmesesfecgre=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCMESESFECGRE")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"MESESFEACTFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLMESESFEACTFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMESESFEACT",gxz:"ZV10cmesesfeact",gxold:"OV10cmesesfeact",gxvar:"AV10cmesesfeact",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cmesesfeact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10cmesesfeact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCMESESFEACT",gx.O.AV10cmesesfeact,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cmesesfeact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCMESESFEACT")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"GRIDTABLE",grid:0};n[59]={fld:"",grid:0};n[60]={fld:"",grid:0};n[62]={fld:"",grid:0};n[63]={fld:"",grid:0};n[65]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64),gx.O.AV5LinkSelection,gx.O.AV15Linkselection_GXI)},c2v:function(){gx.O.AV15Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(64))},gxvar_GXI:"AV15Linkselection_GXI",nac:gx.falseFn};n[66]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MESESID",gxz:"Z11mesesid",gxold:"O11mesesid",gxvar:"A11mesesid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A11mesesid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11mesesid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("MESESID",n||gx.fn.currentGridRowImpl(64),gx.O.A11mesesid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A11mesesid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("MESESID",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[67]={lvl:2,type:"svchar",len:5,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MESESANIO",gxz:"Z61mesesanio",gxold:"O61mesesanio",gxvar:"A61mesesanio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A61mesesanio=n)},v2z:function(n){n!==undefined&&(gx.O.Z61mesesanio=n)},v2c:function(n){gx.fn.setGridControlValue("MESESANIO",n||gx.fn.currentGridRowImpl(64),gx.O.A61mesesanio,0)},c2v:function(){this.val()!==undefined&&(gx.O.A61mesesanio=this.val())},val:function(n){return gx.fn.getGridControlValue("MESESANIO",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[68]={lvl:2,type:"svchar",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MESESUSUARIO",gxz:"Z62mesesusuario",gxold:"O62mesesusuario",gxvar:"A62mesesusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A62mesesusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z62mesesusuario=n)},v2c:function(n){gx.fn.setGridControlValue("MESESUSUARIO",n||gx.fn.currentGridRowImpl(64),gx.O.A62mesesusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A62mesesusuario=this.val())},val:function(n){return gx.fn.getGridControlValue("MESESUSUARIO",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[69]={lvl:2,type:"dtime",len:10,dec:8,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MESESFECGRE",gxz:"Z63mesesfecgre",gxold:"O63mesesfecgre",gxvar:"A63mesesfecgre",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A63mesesfecgre=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z63mesesfecgre=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("MESESFECGRE",n||gx.fn.currentGridRowImpl(64),gx.O.A63mesesfecgre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A63mesesfecgre=gx.fn.toDatetimeValue(this.val()))},val:function(n){return gx.fn.getGridDateTimeValue("MESESFECGRE",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[70]={lvl:2,type:"dtime",len:10,dec:8,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MESESFEACT",gxz:"Z64mesesfeact",gxold:"O64mesesfeact",gxvar:"A64mesesfeact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A64mesesfeact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z64mesesfeact=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("MESESFEACT",n||gx.fn.currentGridRowImpl(64),gx.O.A64mesesfeact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A64mesesfeact=gx.fn.toDatetimeValue(this.val()))},val:function(n){return gx.fn.getGridDateTimeValue("MESESFEACT",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[71]={fld:"",grid:0};n[72]={fld:"",grid:0};this.AV6cmesesid=0;this.ZV6cmesesid=0;this.OV6cmesesid=0;this.AV7cmesesanio="";this.ZV7cmesesanio="";this.OV7cmesesanio="";this.AV8cmesesusuario="";this.ZV8cmesesusuario="";this.OV8cmesesusuario="";this.AV9cmesesfecgre=gx.date.nullDate();this.ZV9cmesesfecgre=gx.date.nullDate();this.OV9cmesesfecgre=gx.date.nullDate();this.AV10cmesesfeact=gx.date.nullDate();this.ZV10cmesesfeact=gx.date.nullDate();this.OV10cmesesfeact=gx.date.nullDate();this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z11mesesid=0;this.O11mesesid=0;this.Z61mesesanio="";this.O61mesesanio="";this.Z62mesesusuario="";this.O62mesesusuario="";this.Z63mesesfecgre=gx.date.nullDate();this.O63mesesfecgre=gx.date.nullDate();this.Z64mesesfeact=gx.date.nullDate();this.O64mesesfeact=gx.date.nullDate();this.AV6cmesesid=0;this.AV7cmesesanio="";this.AV8cmesesusuario="";this.AV9cmesesfecgre=gx.date.nullDate();this.AV10cmesesfeact=gx.date.nullDate();this.AV11pmesesid=0;this.AV5LinkSelection="";this.A11mesesid=0;this.A61mesesanio="";this.A62mesesusuario="";this.A63mesesfecgre=gx.date.nullDate();this.A64mesesfeact=gx.date.nullDate();this.Events={e191s2_client:["ENTER",!0],e201s1_client:["CANCEL",!0],e161s1_client:["'TOGGLE'",!1],e111s1_client:["LBLMESESIDFILTER.CLICK",!1],e121s1_client:["LBLMESESANIOFILTER.CLICK",!1],e131s1_client:["LBLMESESUSUARIOFILTER.CLICK",!1],e141s1_client:["LBLMESESFECGREFILTER.CLICK",!1],e151s1_client:["LBLMESESFEACTFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmesesid",fld:"vCMESESID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cmesesanio",fld:"vCMESESANIO",pic:"",nv:""},{av:"AV8cmesesusuario",fld:"vCMESESUSUARIO",pic:"",nv:""},{av:"AV9cmesesfecgre",fld:"vCMESESFECGRE",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10cmesesfeact",fld:"vCMESESFEACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLMESESIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MESESIDFILTERCONTAINER","Class")',ctrl:"MESESIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MESESIDFILTERCONTAINER","Class")',ctrl:"MESESIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMESESID","Visible")',ctrl:"vCMESESID",prop:"Visible"}]];this.EvtParms["LBLMESESANIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MESESANIOFILTERCONTAINER","Class")',ctrl:"MESESANIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MESESANIOFILTERCONTAINER","Class")',ctrl:"MESESANIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMESESANIO","Visible")',ctrl:"vCMESESANIO",prop:"Visible"}]];this.EvtParms["LBLMESESUSUARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MESESUSUARIOFILTERCONTAINER","Class")',ctrl:"MESESUSUARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MESESUSUARIOFILTERCONTAINER","Class")',ctrl:"MESESUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMESESUSUARIO","Visible")',ctrl:"vCMESESUSUARIO",prop:"Visible"}]];this.EvtParms["LBLMESESFECGREFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MESESFECGREFILTERCONTAINER","Class")',ctrl:"MESESFECGREFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MESESFECGREFILTERCONTAINER","Class")',ctrl:"MESESFECGREFILTERCONTAINER",prop:"Class"}]];this.EvtParms["LBLMESESFEACTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MESESFEACTFILTERCONTAINER","Class")',ctrl:"MESESFEACTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MESESFEACTFILTERCONTAINER","Class")',ctrl:"MESESFEACTFILTERCONTAINER",prop:"Class"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A11mesesid",fld:"MESESID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV11pmesesid",fld:"vPMESESID",pic:"ZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmesesid",fld:"vCMESESID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cmesesanio",fld:"vCMESESANIO",pic:"",nv:""},{av:"AV8cmesesusuario",fld:"vCMESESUSUARIO",pic:"",nv:""},{av:"AV9cmesesfecgre",fld:"vCMESESFECGRE",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10cmesesfeact",fld:"vCMESESFEACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmesesid",fld:"vCMESESID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cmesesanio",fld:"vCMESESANIO",pic:"",nv:""},{av:"AV8cmesesusuario",fld:"vCMESESUSUARIO",pic:"",nv:""},{av:"AV9cmesesfecgre",fld:"vCMESESFECGRE",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10cmesesfeact",fld:"vCMESESFEACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmesesid",fld:"vCMESESID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cmesesanio",fld:"vCMESESANIO",pic:"",nv:""},{av:"AV8cmesesusuario",fld:"vCMESESUSUARIO",pic:"",nv:""},{av:"AV9cmesesfecgre",fld:"vCMESESFECGRE",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10cmesesfeact",fld:"vCMESESFEACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmesesid",fld:"vCMESESID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cmesesanio",fld:"vCMESESANIO",pic:"",nv:""},{av:"AV8cmesesusuario",fld:"vCMESESUSUARIO",pic:"",nv:""},{av:"AV9cmesesfecgre",fld:"vCMESESFECGRE",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10cmesesfeact",fld:"vCMESESFEACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.setVCMap("AV11pmesesid","vPMESESID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);this.InitStandaloneVars()});gx.createParentObj(gx0030)