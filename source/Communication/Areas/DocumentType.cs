﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using ECM.Communication.Elements;

namespace ECM.Communication.Areas
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[Serializable()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class DocumentType
	{

		private RegNumber regNumberField;

		private Confident confidentField;

		private List<Referred> referredField;

		private List<DocNumber> docNumberField;

		private List<Addressee> addresseeField;

		private List<DocTransfer> docTransferField;

		private List<RegHistory> regHistoryField;

		private List<Author> authorField;

		private List<Validator> validatorField;

		private Writer writerField;

		private string idnumberField;

		private sbyte typeField;

		private string kindField;

		private ulong pagesField;

		private bool pagesFieldSpecified;

		private string titleField;

		private string annotationField;

		private sbyte collectionField;

		private bool collectionFieldSpecified;

		private static System.Xml.Serialization.XmlSerializer serializer;

		public DocumentType()
		{
			this.writerField = new Writer();
			this.validatorField = new List<Validator>();
			this.authorField = new List<Author>();
			this.regHistoryField = new List<RegHistory>();
			this.docTransferField = new List<DocTransfer>();
			this.addresseeField = new List<Addressee>();
			this.docNumberField = new List<DocNumber>();
			this.referredField = new List<Referred>();
			this.confidentField = new Confident();
			this.regNumberField = new RegNumber();
		}

		[System.Xml.Serialization.XmlElementAttribute(Order = 0)]
		public RegNumber RegNumber
		{
			get
			{
				return this.regNumberField;
			}
			set
			{
				this.regNumberField = value;
			}
		}

		[System.Xml.Serialization.XmlElementAttribute(Order = 1)]
		public Confident Confident
		{
			get
			{
				return this.confidentField;
			}
			set
			{
				this.confidentField = value;
			}
		}

		[System.Xml.Serialization.XmlElementAttribute("Referred", Order = 2)]
		public List<Referred> Referred
		{
			get
			{
				return this.referredField;
			}
			set
			{
				this.referredField = value;
			}
		}

		[System.Xml.Serialization.XmlElementAttribute("DocNumber", Order = 3)]
		public List<DocNumber> DocNumber
		{
			get
			{
				return this.docNumberField;
			}
			set
			{
				this.docNumberField = value;
			}
		}

		[System.Xml.Serialization.XmlElementAttribute("Addressee", Order = 4)]
		public List<Addressee> Addressee
		{
			get
			{
				return this.addresseeField;
			}
			set
			{
				this.addresseeField = value;
			}
		}

		[System.Xml.Serialization.XmlElementAttribute("DocTransfer", Order = 5)]
		public List<DocTransfer> DocTransfer
		{
			get
			{
				return this.docTransferField;
			}
			set
			{
				this.docTransferField = value;
			}
		}

		[System.Xml.Serialization.XmlElementAttribute("RegHistory", Order = 6)]
		public List<RegHistory> RegHistory
		{
			get
			{
				return this.regHistoryField;
			}
			set
			{
				this.regHistoryField = value;
			}
		}

		[System.Xml.Serialization.XmlElementAttribute("Author", Order = 7)]
		public List<Author> Author
		{
			get
			{
				return this.authorField;
			}
			set
			{
				this.authorField = value;
			}
		}

		[System.Xml.Serialization.XmlElementAttribute("Validator", Order = 8)]
		public List<Validator> Validator
		{
			get
			{
				return this.validatorField;
			}
			set
			{
				this.validatorField = value;
			}
		}

		[System.Xml.Serialization.XmlElementAttribute(Order = 9)]
		public Writer Writer
		{
			get
			{
				return this.writerField;
			}
			set
			{
				this.writerField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string idnumber
		{
			get
			{
				return this.idnumberField;
			}
			set
			{
				this.idnumberField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public sbyte type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string kind
		{
			get
			{
				return this.kindField;
			}
			set
			{
				this.kindField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public ulong pages
		{
			get
			{
				return this.pagesField;
			}
			set
			{
				this.pagesField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool pagesSpecified
		{
			get
			{
				return this.pagesFieldSpecified;
			}
			set
			{
				this.pagesFieldSpecified = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string annotation
		{
			get
			{
				return this.annotationField;
			}
			set
			{
				this.annotationField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public sbyte collection
		{
			get
			{
				return this.collectionField;
			}
			set
			{
				this.collectionField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool collectionSpecified
		{
			get
			{
				return this.collectionFieldSpecified;
			}
			set
			{
				this.collectionFieldSpecified = value;
			}
		}

		private static System.Xml.Serialization.XmlSerializer Serializer
		{
			get
			{
				if ( (serializer == null) )
				{
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(DocumentType));
				}
				return serializer;
			}
		}

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current DocumentType object into an XML document
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
		/// Deserializes workflow markup into an DocumentType object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output DocumentType object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out DocumentType obj, out System.Exception exception)
		{
			exception = null;
			obj = default(DocumentType);
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

		public static bool Deserialize(string xml, out DocumentType obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static DocumentType Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((DocumentType) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
		/// Serializes current DocumentType object into file
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
		/// Deserializes xml markup from file into an DocumentType object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output DocumentType object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out DocumentType obj, out System.Exception exception)
		{
			exception = null;
			obj = default(DocumentType);
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

		public static bool LoadFromFile(string fileName, out DocumentType obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out DocumentType obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static DocumentType LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static DocumentType LoadFromFile(string fileName, System.Text.Encoding encoding)
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
}