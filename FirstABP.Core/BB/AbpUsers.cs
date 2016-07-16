using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class AbpUsers
	{
		#region Constructor
		public AbpUsers() { }

		public AbpUsers(Int64 id,Int32 tenantId,String authenticationSource,String name,String surname,String userName,String password,String emailAddress,Boolean isEmailConfirmed,String emailConfirmationCode,String passwordResetCode,DateTime lastLoginTime,Boolean isActive,Boolean isDeleted,Int64 deleterUserId,DateTime deletionTime,DateTime lastModificationTime,Int64 lastModifierUserId,DateTime creationTime,Int64 creatorUserId)
		{
			this.id = id;
			this.tenantId = tenantId;
			this.authenticationSource = authenticationSource;
			this.name = name;
			this.surname = surname;
			this.userName = userName;
			this.password = password;
			this.emailAddress = emailAddress;
			this.isEmailConfirmed = isEmailConfirmed;
			this.emailConfirmationCode = emailConfirmationCode;
			this.passwordResetCode = passwordResetCode;
			this.lastLoginTime = lastLoginTime;
			this.isActive = isActive;
			this.isDeleted = isDeleted;
			this.deleterUserId = deleterUserId;
			this.deletionTime = deletionTime;
			this.lastModificationTime = lastModificationTime;
			this.lastModifierUserId = lastModifierUserId;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private String authenticationSource;

		public String AuthenticationSource
		{
			get { return authenticationSource; }
			set { authenticationSource = value; }
		}
		private String name;

		public String Name
		{
			get { return name; }
			set { name = value; }
		}
		private String surname;

		public String Surname
		{
			get { return surname; }
			set { surname = value; }
		}
		private String userName;

		public String UserName
		{
			get { return userName; }
			set { userName = value; }
		}
		private String password;

		public String Password
		{
			get { return password; }
			set { password = value; }
		}
		private String emailAddress;

		public String EmailAddress
		{
			get { return emailAddress; }
			set { emailAddress = value; }
		}
		private Boolean isEmailConfirmed;

		public Boolean IsEmailConfirmed
		{
			get { return isEmailConfirmed; }
			set { isEmailConfirmed = value; }
		}
		private String emailConfirmationCode;

		public String EmailConfirmationCode
		{
			get { return emailConfirmationCode; }
			set { emailConfirmationCode = value; }
		}
		private String passwordResetCode;

		public String PasswordResetCode
		{
			get { return passwordResetCode; }
			set { passwordResetCode = value; }
		}
		private DateTime? lastLoginTime;

		public DateTime? LastLoginTime
		{
			get { return lastLoginTime; }
			set { lastLoginTime = value; }
		}
		private Boolean isActive;

		public Boolean IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}
		private Boolean isDeleted;

		public Boolean IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
		}
		private Int64 deleterUserId;

		public Int64 DeleterUserId
		{
			get { return deleterUserId; }
			set { deleterUserId = value; }
		}
		private DateTime? deletionTime;

		public DateTime? DeletionTime
		{
			get { return deletionTime; }
			set { deletionTime = value; }
		}
		private DateTime? lastModificationTime;

		public DateTime? LastModificationTime
		{
			get { return lastModificationTime; }
			set { lastModificationTime = value; }
		}
		private Int64 lastModifierUserId;

		public Int64 LastModifierUserId
		{
			get { return lastModifierUserId; }
			set { lastModifierUserId = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.AuthenticationSource != null && 64 < this.AuthenticationSource.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of AuthenticationSource should not be greater then 64!");
			}
			if (string.IsNullOrEmpty(this.Name))
			{
				validatorResult = false;
				this.ErrorList.Add("The Name should not be empty!");
			}
			if (this.Name != null && 32 < this.Name.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Name should not be greater then 32!");
			}
			if (string.IsNullOrEmpty(this.Surname))
			{
				validatorResult = false;
				this.ErrorList.Add("The Surname should not be empty!");
			}
			if (this.Surname != null && 32 < this.Surname.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Surname should not be greater then 32!");
			}
			if (string.IsNullOrEmpty(this.UserName))
			{
				validatorResult = false;
				this.ErrorList.Add("The UserName should not be empty!");
			}
			if (this.UserName != null && 32 < this.UserName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of UserName should not be greater then 32!");
			}
			if (string.IsNullOrEmpty(this.Password))
			{
				validatorResult = false;
				this.ErrorList.Add("The Password should not be empty!");
			}
			if (this.Password != null && 128 < this.Password.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Password should not be greater then 128!");
			}
			if (string.IsNullOrEmpty(this.EmailAddress))
			{
				validatorResult = false;
				this.ErrorList.Add("The EmailAddress should not be empty!");
			}
			if (this.EmailAddress != null && 256 < this.EmailAddress.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EmailAddress should not be greater then 256!");
			}
			if (this.EmailConfirmationCode != null && 128 < this.EmailConfirmationCode.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EmailConfirmationCode should not be greater then 128!");
			}
			if (this.PasswordResetCode != null && 328 < this.PasswordResetCode.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of PasswordResetCode should not be greater then 328!");
			}
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
