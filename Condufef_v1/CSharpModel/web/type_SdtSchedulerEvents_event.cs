/*
               File: type_SdtSchedulerEvents_event
        Description: SchedulerEvents
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/30/2022 23:38:55.93
       Program type: Callable routine
          Main DBMS: postgresql
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Web.Services.Protocols;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "SchedulerEvents.event" )]
   [XmlType(TypeName =  "SchedulerEvents.event" , Namespace = "" )]
   [Serializable]
   public class SdtSchedulerEvents_event : GxUserType
   {
      public SdtSchedulerEvents_event( )
      {
         /* Constructor for serialization */
         gxTv_SdtSchedulerEvents_event_Id = "";
         gxTv_SdtSchedulerEvents_event_Name = "";
         gxTv_SdtSchedulerEvents_event_Notes = "";
         gxTv_SdtSchedulerEvents_event_Link = "";
         gxTv_SdtSchedulerEvents_event_Starttime = (DateTime)(DateTime.MinValue);
         gxTv_SdtSchedulerEvents_event_Endtime = (DateTime)(DateTime.MinValue);
         gxTv_SdtSchedulerEvents_event_Additionalinformation = "";
         gxTv_SdtSchedulerEvents_event_Color = "";
         gxTv_SdtSchedulerEvents_event_Color_N = 1;
         gxTv_SdtSchedulerEvents_event_Backgroundcolor = "";
         gxTv_SdtSchedulerEvents_event_Backgroundcolor_N = 1;
         gxTv_SdtSchedulerEvents_event_Nameweekview = "";
         gxTv_SdtSchedulerEvents_event_Nameweekview_N = 1;
         gxTv_SdtSchedulerEvents_event_Namemonthview = "";
         gxTv_SdtSchedulerEvents_event_Namemonthview_N = 1;
         gxTv_SdtSchedulerEvents_event_Namedayview = "";
         gxTv_SdtSchedulerEvents_event_Namedayview_N = 1;
         gxTv_SdtSchedulerEvents_event_Tooltip = "";
         gxTv_SdtSchedulerEvents_event_Tooltip_N = 1;
      }

      public SdtSchedulerEvents_event( IGxContext context )
      {
         this.context = context;
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public override String ToXml( bool includeHeader ,
                                    bool includeState ,
                                    String name ,
                                    String sNameSpace )
      {
         String s ;
         XmlSerializer xmls ;
         xmls = new XmlSerializer(this.GetType(), sNameSpace);
         System.IO.MemoryStream stream = new System.IO.MemoryStream();
         System.Xml.XmlWriter xmlw = System.Xml.XmlWriter.Create(stream, new System.Xml.XmlWriterSettings() { OmitXmlDeclaration = !includeHeader});
         XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();
         xmlns.Add(String.Empty, sNameSpace);
         xmls.Serialize( xmlw, this, xmlns);
         stream.Seek(0L, System.IO.SeekOrigin.Begin);
         System.IO.StreamReader sr = new System.IO.StreamReader(stream);
         s = sr.ReadToEnd();
         stream.Close();
         return s ;
      }

      public override void FromXml( String s ,
                                    String name )
      {
         SdtSchedulerEvents_event deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType());
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtSchedulerEvents_event)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtSchedulerEvents_event obj ;
         obj = this;
         obj.gxTpr_Id = deserialized.gxTpr_Id;
         obj.gxTpr_Name = deserialized.gxTpr_Name;
         obj.gxTpr_Notes = deserialized.gxTpr_Notes;
         obj.gxTpr_Link = deserialized.gxTpr_Link;
         obj.gxTpr_Starttime = deserialized.gxTpr_Starttime;
         obj.gxTpr_Endtime = deserialized.gxTpr_Endtime;
         obj.gxTpr_Additionalinformation = deserialized.gxTpr_Additionalinformation;
         obj.gxTpr_Color = deserialized.gxTpr_Color;
         obj.gxTpr_Backgroundcolor = deserialized.gxTpr_Backgroundcolor;
         obj.gxTpr_Nameweekview = deserialized.gxTpr_Nameweekview;
         obj.gxTpr_Namemonthview = deserialized.gxTpr_Namemonthview;
         obj.gxTpr_Namedayview = deserialized.gxTpr_Namedayview;
         obj.gxTpr_Tooltip = deserialized.gxTpr_Tooltip;
         return  ;
      }

      public override short readxml( GXXMLReader oReader ,
                                     String sName )
      {
         short GXSoapError = 1 ;
         sTagName = oReader.Name;
         if ( oReader.IsSimple == 0 )
         {
            GXSoapError = oReader.Read();
            nOutParmCount = 0;
            while ( ( ( StringUtil.StrCmp(oReader.Name, sTagName) != 0 ) || ( oReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
            {
               readOk = 0;
               if ( StringUtil.StrCmp2( oReader.LocalName, "Id") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Id = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Name") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Name = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Notes") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Notes = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Link") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Link = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "StartTime") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtSchedulerEvents_event_Starttime = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_SdtSchedulerEvents_event_Starttime = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "EndTime") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtSchedulerEvents_event_Endtime = (DateTime)(DateTime.MinValue);
                  }
                  else
                  {
                     gxTv_SdtSchedulerEvents_event_Endtime = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AdditionalInformation") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Additionalinformation = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Color") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Color = oReader.Value;
                  gxTv_SdtSchedulerEvents_event_Color_N = 0;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "BackgroundColor") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Backgroundcolor = oReader.Value;
                  gxTv_SdtSchedulerEvents_event_Backgroundcolor_N = 0;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "NameWeekView") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Nameweekview = oReader.Value;
                  gxTv_SdtSchedulerEvents_event_Nameweekview_N = 0;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "NameMonthView") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Namemonthview = oReader.Value;
                  gxTv_SdtSchedulerEvents_event_Namemonthview_N = 0;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "NameDayView") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Namedayview = oReader.Value;
                  gxTv_SdtSchedulerEvents_event_Namedayview_N = 0;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "ToolTip") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Tooltip = oReader.Value;
                  gxTv_SdtSchedulerEvents_event_Tooltip_N = 0;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               nOutParmCount = (short)(nOutParmCount+1);
               if ( readOk == 0 )
               {
                  context.sSOAPErrMsg = context.sSOAPErrMsg + "Error reading " + sTagName + StringUtil.NewLine( );
                  context.sSOAPErrMsg = context.sSOAPErrMsg + "Message: " + oReader.ReadRawXML();
                  GXSoapError = (short)(nOutParmCount*-1);
               }
            }
         }
         return GXSoapError ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace )
      {
         writexml(oWriter, sName, sNameSpace, true);
         return  ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace ,
                                     bool sIncludeState )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sName)) )
         {
            sName = "SchedulerEvents.event";
         }
         oWriter.WriteStartElement(sName);
         if ( StringUtil.StrCmp(StringUtil.Left( sNameSpace, 10), "[*:nosend]") != 0 )
         {
            oWriter.WriteAttribute("xmlns", sNameSpace);
         }
         else
         {
            sNameSpace = StringUtil.Right( sNameSpace, (short)(StringUtil.Len( sNameSpace)-10));
         }
         oWriter.WriteElement("Id", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Id));
         if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "");
         }
         oWriter.WriteElement("Name", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Name));
         if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "");
         }
         oWriter.WriteElement("Notes", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Notes));
         if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "");
         }
         oWriter.WriteElement("Link", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Link));
         if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "");
         }
         if ( (DateTime.MinValue==gxTv_SdtSchedulerEvents_event_Starttime) )
         {
            oWriter.WriteStartElement("StartTime");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("StartTime", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         if ( (DateTime.MinValue==gxTv_SdtSchedulerEvents_event_Endtime) )
         {
            oWriter.WriteStartElement("EndTime");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("EndTime", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         oWriter.WriteElement("AdditionalInformation", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Additionalinformation));
         if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "");
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Color)) || ( gxTv_SdtSchedulerEvents_event_Color_N != 1 ) )
         {
            oWriter.WriteElement("Color", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Color));
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Backgroundcolor)) || ( gxTv_SdtSchedulerEvents_event_Backgroundcolor_N != 1 ) )
         {
            oWriter.WriteElement("BackgroundColor", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Backgroundcolor));
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Nameweekview)) || ( gxTv_SdtSchedulerEvents_event_Nameweekview_N != 1 ) )
         {
            oWriter.WriteElement("NameWeekView", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Nameweekview));
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Namemonthview)) || ( gxTv_SdtSchedulerEvents_event_Namemonthview_N != 1 ) )
         {
            oWriter.WriteElement("NameMonthView", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Namemonthview));
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Namedayview)) || ( gxTv_SdtSchedulerEvents_event_Namedayview_N != 1 ) )
         {
            oWriter.WriteElement("NameDayView", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Namedayview));
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Tooltip)) || ( gxTv_SdtSchedulerEvents_event_Tooltip_N != 1 ) )
         {
            oWriter.WriteElement("ToolTip", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Tooltip));
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("Id", gxTv_SdtSchedulerEvents_event_Id, false);
         AddObjectProperty("Name", gxTv_SdtSchedulerEvents_event_Name, false);
         AddObjectProperty("Notes", gxTv_SdtSchedulerEvents_event_Notes, false);
         AddObjectProperty("Link", gxTv_SdtSchedulerEvents_event_Link, false);
         datetime_STZ = gxTv_SdtSchedulerEvents_event_Starttime;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("StartTime", sDateCnv, false);
         datetime_STZ = gxTv_SdtSchedulerEvents_event_Endtime;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("EndTime", sDateCnv, false);
         AddObjectProperty("AdditionalInformation", gxTv_SdtSchedulerEvents_event_Additionalinformation, false);
         AddObjectProperty("Color", gxTv_SdtSchedulerEvents_event_Color, false);
         AddObjectProperty("BackgroundColor", gxTv_SdtSchedulerEvents_event_Backgroundcolor, false);
         AddObjectProperty("NameWeekView", gxTv_SdtSchedulerEvents_event_Nameweekview, false);
         AddObjectProperty("NameMonthView", gxTv_SdtSchedulerEvents_event_Namemonthview, false);
         AddObjectProperty("NameDayView", gxTv_SdtSchedulerEvents_event_Namedayview, false);
         AddObjectProperty("ToolTip", gxTv_SdtSchedulerEvents_event_Tooltip, false);
         return  ;
      }

      [  SoapElement( ElementName = "Id" )]
      [  XmlElement( ElementName = "Id"   )]
      public String gxTpr_Id
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Id ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Id = (String)(value);
         }

      }

      [  SoapElement( ElementName = "Name" )]
      [  XmlElement( ElementName = "Name"   )]
      public String gxTpr_Name
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Name ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Name = (String)(value);
         }

      }

      [  SoapElement( ElementName = "Notes" )]
      [  XmlElement( ElementName = "Notes" , Namespace = ""  )]
      public String gxTpr_Notes
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Notes ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Notes = (String)(value);
         }

      }

      [  SoapElement( ElementName = "Link" )]
      [  XmlElement( ElementName = "Link"   )]
      public String gxTpr_Link
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Link ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Link = (String)(value);
         }

      }

      [  SoapElement( ElementName = "StartTime" )]
      [  XmlElement( ElementName = "StartTime"  , IsNullable=true )]
      public string gxTpr_Starttime_Nullable
      {
         get {
            if ( gxTv_SdtSchedulerEvents_event_Starttime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSchedulerEvents_event_Starttime).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_SdtSchedulerEvents_event_Starttime = DateTime.MinValue;
            else
               gxTv_SdtSchedulerEvents_event_Starttime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Starttime
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Starttime ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Starttime = (DateTime)(value);
         }

      }

      [  SoapElement( ElementName = "EndTime" )]
      [  XmlElement( ElementName = "EndTime"  , IsNullable=true )]
      public string gxTpr_Endtime_Nullable
      {
         get {
            if ( gxTv_SdtSchedulerEvents_event_Endtime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSchedulerEvents_event_Endtime).value ;
         }

         set {
            if (value == null || value == GxDatetimeString.NullValue )
               gxTv_SdtSchedulerEvents_event_Endtime = DateTime.MinValue;
            else
               gxTv_SdtSchedulerEvents_event_Endtime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Endtime
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Endtime ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Endtime = (DateTime)(value);
         }

      }

      [  SoapElement( ElementName = "AdditionalInformation" )]
      [  XmlElement( ElementName = "AdditionalInformation" , Namespace = ""  )]
      public String gxTpr_Additionalinformation
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Additionalinformation ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Additionalinformation = (String)(value);
         }

      }

      [  SoapElement( ElementName = "Color" )]
      [  XmlElement( ElementName = "Color"   )]
      public String gxTpr_Color
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Color ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Color_N = 0;
            gxTv_SdtSchedulerEvents_event_Color = (String)(value);
         }

      }

      public bool ShouldSerializegxTpr_Color( )
      {
         return (bool)(gxTv_SdtSchedulerEvents_event_Color_N == 0) ;
      }

      [  SoapElement( ElementName = "BackgroundColor" )]
      [  XmlElement( ElementName = "BackgroundColor"   )]
      public String gxTpr_Backgroundcolor
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Backgroundcolor ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Backgroundcolor_N = 0;
            gxTv_SdtSchedulerEvents_event_Backgroundcolor = (String)(value);
         }

      }

      public bool ShouldSerializegxTpr_Backgroundcolor( )
      {
         return (bool)(gxTv_SdtSchedulerEvents_event_Backgroundcolor_N == 0) ;
      }

      [  SoapElement( ElementName = "NameWeekView" )]
      [  XmlElement( ElementName = "NameWeekView"   )]
      public String gxTpr_Nameweekview
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Nameweekview ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Nameweekview_N = 0;
            gxTv_SdtSchedulerEvents_event_Nameweekview = (String)(value);
         }

      }

      public bool ShouldSerializegxTpr_Nameweekview( )
      {
         return (bool)(gxTv_SdtSchedulerEvents_event_Nameweekview_N == 0) ;
      }

      [  SoapElement( ElementName = "NameMonthView" )]
      [  XmlElement( ElementName = "NameMonthView"   )]
      public String gxTpr_Namemonthview
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Namemonthview ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Namemonthview_N = 0;
            gxTv_SdtSchedulerEvents_event_Namemonthview = (String)(value);
         }

      }

      public bool ShouldSerializegxTpr_Namemonthview( )
      {
         return (bool)(gxTv_SdtSchedulerEvents_event_Namemonthview_N == 0) ;
      }

      [  SoapElement( ElementName = "NameDayView" )]
      [  XmlElement( ElementName = "NameDayView"   )]
      public String gxTpr_Namedayview
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Namedayview ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Namedayview_N = 0;
            gxTv_SdtSchedulerEvents_event_Namedayview = (String)(value);
         }

      }

      public bool ShouldSerializegxTpr_Namedayview( )
      {
         return (bool)(gxTv_SdtSchedulerEvents_event_Namedayview_N == 0) ;
      }

      [  SoapElement( ElementName = "ToolTip" )]
      [  XmlElement( ElementName = "ToolTip"   )]
      public String gxTpr_Tooltip
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Tooltip ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Tooltip_N = 0;
            gxTv_SdtSchedulerEvents_event_Tooltip = (String)(value);
         }

      }

      public bool ShouldSerializegxTpr_Tooltip( )
      {
         return (bool)(gxTv_SdtSchedulerEvents_event_Tooltip_N == 0) ;
      }

      public void initialize( )
      {
         gxTv_SdtSchedulerEvents_event_Id = "";
         gxTv_SdtSchedulerEvents_event_Name = "";
         gxTv_SdtSchedulerEvents_event_Notes = "";
         gxTv_SdtSchedulerEvents_event_Link = "";
         gxTv_SdtSchedulerEvents_event_Starttime = (DateTime)(DateTime.MinValue);
         gxTv_SdtSchedulerEvents_event_Endtime = (DateTime)(DateTime.MinValue);
         gxTv_SdtSchedulerEvents_event_Additionalinformation = "";
         gxTv_SdtSchedulerEvents_event_Color = "";
         gxTv_SdtSchedulerEvents_event_Color_N = 1;
         gxTv_SdtSchedulerEvents_event_Backgroundcolor = "";
         gxTv_SdtSchedulerEvents_event_Backgroundcolor_N = 1;
         gxTv_SdtSchedulerEvents_event_Nameweekview = "";
         gxTv_SdtSchedulerEvents_event_Nameweekview_N = 1;
         gxTv_SdtSchedulerEvents_event_Namemonthview = "";
         gxTv_SdtSchedulerEvents_event_Namemonthview_N = 1;
         gxTv_SdtSchedulerEvents_event_Namedayview = "";
         gxTv_SdtSchedulerEvents_event_Namedayview_N = 1;
         gxTv_SdtSchedulerEvents_event_Tooltip = "";
         gxTv_SdtSchedulerEvents_event_Tooltip_N = 1;
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         return  ;
      }

      protected short gxTv_SdtSchedulerEvents_event_Color_N ;
      protected short gxTv_SdtSchedulerEvents_event_Backgroundcolor_N ;
      protected short gxTv_SdtSchedulerEvents_event_Nameweekview_N ;
      protected short gxTv_SdtSchedulerEvents_event_Namemonthview_N ;
      protected short gxTv_SdtSchedulerEvents_event_Namedayview_N ;
      protected short gxTv_SdtSchedulerEvents_event_Tooltip_N ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtSchedulerEvents_event_Id ;
      protected String gxTv_SdtSchedulerEvents_event_Name ;
      protected String gxTv_SdtSchedulerEvents_event_Notes ;
      protected String gxTv_SdtSchedulerEvents_event_Link ;
      protected String gxTv_SdtSchedulerEvents_event_Additionalinformation ;
      protected String gxTv_SdtSchedulerEvents_event_Color ;
      protected String gxTv_SdtSchedulerEvents_event_Backgroundcolor ;
      protected String gxTv_SdtSchedulerEvents_event_Nameweekview ;
      protected String gxTv_SdtSchedulerEvents_event_Namemonthview ;
      protected String gxTv_SdtSchedulerEvents_event_Namedayview ;
      protected String gxTv_SdtSchedulerEvents_event_Tooltip ;
      protected String sTagName ;
      protected String sDateCnv ;
      protected String sNumToPad ;
      protected DateTime gxTv_SdtSchedulerEvents_event_Starttime ;
      protected DateTime gxTv_SdtSchedulerEvents_event_Endtime ;
      protected DateTime datetime_STZ ;
   }

   [DataContract(Name = @"SchedulerEvents.event", Namespace = "")]
   public class SdtSchedulerEvents_event_RESTInterface : GxGenericCollectionItem<SdtSchedulerEvents_event>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSchedulerEvents_event_RESTInterface( ) : base()
      {
      }

      public SdtSchedulerEvents_event_RESTInterface( SdtSchedulerEvents_event psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Id" , Order = 0 )]
      public String gxTpr_Id
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Id) ;
         }

         set {
            sdt.gxTpr_Id = (String)(value);
         }

      }

      [DataMember( Name = "Name" , Order = 1 )]
      public String gxTpr_Name
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Name) ;
         }

         set {
            sdt.gxTpr_Name = (String)(value);
         }

      }

      [DataMember( Name = "Notes" , Order = 2 )]
      public String gxTpr_Notes
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Notes) ;
         }

         set {
            sdt.gxTpr_Notes = (String)(value);
         }

      }

      [DataMember( Name = "Link" , Order = 3 )]
      public String gxTpr_Link
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Link) ;
         }

         set {
            sdt.gxTpr_Link = (String)(value);
         }

      }

      [DataMember( Name = "StartTime" , Order = 4 )]
      public String gxTpr_Starttime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Starttime) ;
         }

         set {
            sdt.gxTpr_Starttime = DateTimeUtil.CToT2( (String)(value));
         }

      }

      [DataMember( Name = "EndTime" , Order = 5 )]
      public String gxTpr_Endtime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Endtime) ;
         }

         set {
            sdt.gxTpr_Endtime = DateTimeUtil.CToT2( (String)(value));
         }

      }

      [DataMember( Name = "AdditionalInformation" , Order = 6 )]
      public String gxTpr_Additionalinformation
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Additionalinformation) ;
         }

         set {
            sdt.gxTpr_Additionalinformation = (String)(value);
         }

      }

      [DataMember( Name = "Color" , Order = 7 )]
      public String gxTpr_Color
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Color) ;
         }

         set {
            sdt.gxTpr_Color = (String)(value);
         }

      }

      [DataMember( Name = "BackgroundColor" , Order = 8 )]
      public String gxTpr_Backgroundcolor
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Backgroundcolor) ;
         }

         set {
            sdt.gxTpr_Backgroundcolor = (String)(value);
         }

      }

      [DataMember( Name = "NameWeekView" , Order = 9 )]
      public String gxTpr_Nameweekview
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Nameweekview) ;
         }

         set {
            sdt.gxTpr_Nameweekview = (String)(value);
         }

      }

      [DataMember( Name = "NameMonthView" , Order = 10 )]
      public String gxTpr_Namemonthview
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Namemonthview) ;
         }

         set {
            sdt.gxTpr_Namemonthview = (String)(value);
         }

      }

      [DataMember( Name = "NameDayView" , Order = 11 )]
      public String gxTpr_Namedayview
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Namedayview) ;
         }

         set {
            sdt.gxTpr_Namedayview = (String)(value);
         }

      }

      [DataMember( Name = "ToolTip" , Order = 12 )]
      public String gxTpr_Tooltip
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Tooltip) ;
         }

         set {
            sdt.gxTpr_Tooltip = (String)(value);
         }

      }

      public SdtSchedulerEvents_event sdt
      {
         get {
            return (SdtSchedulerEvents_event)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtSchedulerEvents_event() ;
         }
      }

   }

}
