﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using ECM.Communication.Elements;

namespace ECM.Communication.Areas
{
	/// <summary>
	/// Дополнительные материалы
	/// </summary>
	/// <remarks>
	/// Содержит информацию о дополнительных (справочных) материалах к документу, которые разъясняют отдельные, затронутые в документевопросы (в виде дополнительных документов, писем, справок и пр.).
	/// </remarks>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[Serializable()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class AddDocumentsType
	{
		#region Const & Static

		public const string AreaName = "Дополнительные материалы";

		private static System.Xml.Serialization.XmlSerializer serializer;

		#endregion

		#region Properties

		private List<AddDocumentsTypeFolder> folderField;

		#endregion

		#region Constructor

		#endregion

		#region Fields

		[System.Xml.Serialization.XmlElementAttribute("Folder", Order = 0)]
		public List<AddDocumentsTypeFolder> Folder
		{
			get
			{
				return this.folderField;
			}
			set
			{
				this.folderField = value;
			}
		}

		private static System.Xml.Serialization.XmlSerializer Serializer
		{
			get
			{
				if ( (serializer == null) )
				{
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(AddDocumentsType));
				}
				return serializer;
			}
		}

		#endregion

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current AddDocumentsType object into an XML document
		/// </summary>
		/// <returns>string XML value</returns>
		public virtual string Serialize(System.Text.Encoding encoding)
		{
			System.IO.StreamReader streamReader = null;
			System.IO.MemoryStream memoryStream = null;
			try
			{
				memoryStream = new System.IO.MemoryStream();
				System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
				xmlWriterSettings.Encoding = encoding;
				System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
				Serializer.Serialize(xmlWriter, this);
				memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
				streamReader = new System.IO.StreamReader(memoryStream);
				return streamReader.ReadToEnd();
			}
			finally
			{
				if ( (streamReader != null) )
				{
					streamReader.Dispose();
				}
				if ( (memoryStream != null) )
				{
					memoryStream.Dispose();
				}
			}
		}

		public virtual string Serialize()
		{
			return Serialize(Encoding.UTF8);
		}

		/// <summary>
		/// Deserializes workflow markup into an AddDocumentsType object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output AddDocumentsType object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out AddDocumentsType obj, out System.Exception exception)
		{
			exception = null;
			obj = default(AddDocumentsType);
			try
			{
				obj = Deserialize(xml);
				return true;
			}
			catch ( System.Exception ex )
			{
				exception = ex;
				return false;
			}
		}

		public static bool Deserialize(string xml, out AddDocumentsType obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static AddDocumentsType Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((AddDocumentsType) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
			}
			finally
			{
				if ( (stringReader != null) )
				{
					stringReader.Dispose();
				}
			}
		}

		/// <summary>
		/// Serializes current AddDocumentsType object into file
		/// </summary>
		/// <param name="fileName">full path of outupt xml file</param>
		/// <param name="exception">output Exception value if failed</param>
		/// <returns>true if can serialize and save into file; otherwise, false</returns>
		public virtual bool SaveToFile(string fileName, System.Text.Encoding encoding, out System.Exception exception)
		{
			exception = null;
			try
			{
				SaveToFile(fileName, encoding);
				return true;
			}
			catch ( System.Exception e )
			{
				exception = e;
				return false;
			}
		}

		public virtual bool SaveToFile(string fileName, out System.Exception exception)
		{
			return SaveToFile(fileName, Encoding.UTF8, out exception);
		}

		public virtual void SaveToFile(string fileName)
		{
			SaveToFile(fileName, Encoding.UTF8);
		}

		public virtual void SaveToFile(string fileName, System.Text.Encoding encoding)
		{
			System.IO.StreamWriter streamWriter = null;
			try
			{
				string xmlString = Serialize(encoding);
				streamWriter = new System.IO.StreamWriter(fileName, false, Encoding.UTF8);
				streamWriter.WriteLine(xmlString);
				streamWriter.Close();
			}
			finally
			{
				if ( (streamWriter != null) )
				{
					streamWriter.Dispose();
				}
			}
		}

		/// <summary>
		/// Deserializes xml markup from file into an AddDocumentsType object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output AddDocumentsType object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out AddDocumentsType obj, out System.Exception exception)
		{
			exception = null;
			obj = default(AddDocumentsType);
			try
			{
				obj = LoadFromFile(fileName, encoding);
				return true;
			}
			catch ( System.Exception ex )
			{
				exception = ex;
				return false;
			}
		}

		public static bool LoadFromFile(string fileName, out AddDocumentsType obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out AddDocumentsType obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static AddDocumentsType LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static AddDocumentsType LoadFromFile(string fileName, System.Text.Encoding encoding)
		{
			System.IO.FileStream file = null;
			System.IO.StreamReader sr = null;
			try
			{
				file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
				sr = new System.IO.StreamReader(file, encoding);
				string xmlString = sr.ReadToEnd();
				sr.Close();
				file.Close();
				return Deserialize(xmlString);
			}
			finally
			{
				if ( (file != null) )
				{
					file.Dispose();
				}
				if ( (sr != null) )
				{
					sr.Dispose();
				}
			}
		}
		#endregion
	}

	internal static partial class Expansion
	{
		public static List<AckResult> Check(this AddDocumentsType source)
		{
			const string areaName = AddDocumentsType.AreaName;

			var ackResult = new List<AckResult>();

			if ( source == null )
			{
				var ex = ErrorReceiptCode.MissingAreas_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, areaName) });
				return ackResult;
			}

			if ( source.Folder != null ) 
			{
				if ( source.Folder.Count == 1 )
				{
					var data = source.Folder[0];
					ackResult.AddRange(data.Check(areaName));
				}
				else if ( source.Folder.Count > 1 )
				{
					var ex = ErrorReceiptCode.WrongMultiplicityOfElement_Format;
					ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "Folder", areaName) });
				}
			}
			
			return ackResult;
		}
	}
}
