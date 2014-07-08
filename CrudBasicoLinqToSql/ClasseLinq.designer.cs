﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrudBasicoLinqToSql
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="baseDeDados")]
	public partial class ClasseLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPessoa(Pessoa instance);
    partial void UpdatePessoa(Pessoa instance);
    partial void DeletePessoa(Pessoa instance);
    #endregion
		
		public ClasseLinqDataContext() : 
				base(global::CrudBasicoLinqToSql.Properties.Settings.Default.baseDeDadosConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ClasseLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClasseLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClasseLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClasseLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Pessoa> Pessoas
		{
			get
			{
				return this.GetTable<Pessoa>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pessoas")]
	public partial class Pessoa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdPessoa;
		
		private string _Nome;
		
		private string _SobreNome;
		
		private string _Rua;
		
		private string _Bairro;
		
		private string _Cidade;
		
		private string _Uf;
		
		private string _Telefone;
		
		private string _Celular;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdPessoaChanging(int value);
    partial void OnIdPessoaChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnSobreNomeChanging(string value);
    partial void OnSobreNomeChanged();
    partial void OnRuaChanging(string value);
    partial void OnRuaChanged();
    partial void OnBairroChanging(string value);
    partial void OnBairroChanged();
    partial void OnCidadeChanging(string value);
    partial void OnCidadeChanged();
    partial void OnUfChanging(string value);
    partial void OnUfChanged();
    partial void OnTelefoneChanging(string value);
    partial void OnTelefoneChanged();
    partial void OnCelularChanging(string value);
    partial void OnCelularChanged();
    #endregion
		
		public Pessoa()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPessoa", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdPessoa
		{
			get
			{
				return this._IdPessoa;
			}
			set
			{
				if ((this._IdPessoa != value))
				{
					this.OnIdPessoaChanging(value);
					this.SendPropertyChanging();
					this._IdPessoa = value;
					this.SendPropertyChanged("IdPessoa");
					this.OnIdPessoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SobreNome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SobreNome
		{
			get
			{
				return this._SobreNome;
			}
			set
			{
				if ((this._SobreNome != value))
				{
					this.OnSobreNomeChanging(value);
					this.SendPropertyChanging();
					this._SobreNome = value;
					this.SendPropertyChanged("SobreNome");
					this.OnSobreNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rua", DbType="VarChar(50)")]
		public string Rua
		{
			get
			{
				return this._Rua;
			}
			set
			{
				if ((this._Rua != value))
				{
					this.OnRuaChanging(value);
					this.SendPropertyChanging();
					this._Rua = value;
					this.SendPropertyChanged("Rua");
					this.OnRuaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bairro", DbType="VarChar(50)")]
		public string Bairro
		{
			get
			{
				return this._Bairro;
			}
			set
			{
				if ((this._Bairro != value))
				{
					this.OnBairroChanging(value);
					this.SendPropertyChanging();
					this._Bairro = value;
					this.SendPropertyChanged("Bairro");
					this.OnBairroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cidade", DbType="VarChar(50)")]
		public string Cidade
		{
			get
			{
				return this._Cidade;
			}
			set
			{
				if ((this._Cidade != value))
				{
					this.OnCidadeChanging(value);
					this.SendPropertyChanging();
					this._Cidade = value;
					this.SendPropertyChanged("Cidade");
					this.OnCidadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Uf", DbType="VarChar(5)")]
		public string Uf
		{
			get
			{
				return this._Uf;
			}
			set
			{
				if ((this._Uf != value))
				{
					this.OnUfChanging(value);
					this.SendPropertyChanging();
					this._Uf = value;
					this.SendPropertyChanged("Uf");
					this.OnUfChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefone", DbType="VarChar(15)")]
		public string Telefone
		{
			get
			{
				return this._Telefone;
			}
			set
			{
				if ((this._Telefone != value))
				{
					this.OnTelefoneChanging(value);
					this.SendPropertyChanging();
					this._Telefone = value;
					this.SendPropertyChanged("Telefone");
					this.OnTelefoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Celular", DbType="VarChar(15)")]
		public string Celular
		{
			get
			{
				return this._Celular;
			}
			set
			{
				if ((this._Celular != value))
				{
					this.OnCelularChanging(value);
					this.SendPropertyChanging();
					this._Celular = value;
					this.SendPropertyChanged("Celular");
					this.OnCelularChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591