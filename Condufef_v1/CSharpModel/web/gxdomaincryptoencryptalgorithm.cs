/*
               File: CryptoEncryptAlgorithm
        Description: CryptoEncryptAlgorithm
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/2/2022 13:43:37.16
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
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gxdomaincryptoencryptalgorithm
   {
      private static Hashtable domain = new Hashtable();
      static gxdomaincryptoencryptalgorithm ()
      {
         domain["Rijndael"] = "Rijndael";
         domain["DES"] = "DES";
         domain["TripleDES"] = "Triple DES";
      }

      public static string getDescription( IGxContext context ,
                                           String key )
      {
         string rtkey ;
         rtkey = StringUtil.Trim( (String)(key));
         return (string)domain[rtkey] ;
      }

      public static GxSimpleCollection getValues( )
      {
         GxSimpleCollection value = new GxSimpleCollection();
         ArrayList aKeys = new ArrayList(domain.Keys);
         aKeys.Sort();
         foreach (String key in aKeys)
         {
            value.Add(key);
         }
         return value;
      }

   }

}
