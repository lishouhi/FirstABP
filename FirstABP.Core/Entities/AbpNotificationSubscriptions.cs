/*****************************************************************************************
 * Copyright (c) 2000-2016 GUANGDONG NANFANG HAIAN SCIENCE&TECHNOLOGY SERVICE CO.LTD
 * 广东南方海岸科技服务有限公司版权所有2000-2016。
 * 本软件文档资料是广东南方海岸科技服务有限公司的资产,任何人士阅读和使用本资料必
 * 须获得相应的书面授权,承担保密责任和接受相应的法律束.
 *
 * <auto-generated>
 *     此代码由T4模板自动生成
 *       生成时间 2016-07-17 08:27:00 by Houpf
 *     对此文件的更改可能会导致不正确的行为，并且如果
 *     重新生成代码，这些更改将会丢失。
 * </auto-generated>
*****************************************************************************************/

using System;
using Abp.Domain.Entities;

/*****************************************************************************************
 * FileName:AbpNotificationSubscriptions.cs
 * Author:侯鹏飞
 * CreateDate:2016-07-17 08:27:00
 * Description:    
 *        <version>	    |	<author>	|<time>					|	<desc>
 *        1		    	|	侯鹏飞		|2016-07-17 08:27:00	|	创建【】服务类	

 ****************************************************************************************/

namespace FirstABP.Core.Entities
{
	public class AbpNotificationSubscriptions : Entity
	{
		/// <summary>
		/// 
		/// </summary>
        public virtual Guid Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
        public virtual int? TenantId { get; set; }

		/// <summary>
		/// 
		/// </summary>
        public virtual long UserId { get; set; }

		/// <summary>
		/// 
		/// </summary>
        public virtual string NotificationName { get; set; }

		/// <summary>
		/// 
		/// </summary>
        public virtual string EntityTypeName { get; set; }

		/// <summary>
		/// 
		/// </summary>
        public virtual string EntityTypeAssemblyQualifiedName { get; set; }

		/// <summary>
		/// 
		/// </summary>
        public virtual string EntityId { get; set; }

		/// <summary>
		/// 
		/// </summary>
        public virtual DateTime CreationTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
        public virtual long? CreatorUserId { get; set; }

		  
	}
}
