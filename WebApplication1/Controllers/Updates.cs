using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebApplication1.Controllers
{
	[Serializable]
	public class Updates
	{
		/// <summary>
		/// Тип события
		/// </summary>
		[JsonProperty("type",Required = Required.DisallowNull)]
		public string Type { get; set; }

		/// <summary>
		/// Объект, инициировавший событие
		/// Структура объекта зависит от типа уведомления
		/// </summary>
		[JsonProperty("object",Required = Required.DisallowNull)]
		public JObject Object { get; set; }

		/// <summary>
		/// ID сообщества, в котором произошло событие
		/// </summary>
		[JsonProperty("group_id",Required = Required.DisallowNull)]
		public long GroupId { get; set; }

		/// <summary>
		/// Секретный ключ. Передается с каждым уведомлением от сервера
		/// </summary>
		[JsonProperty("secret",Required = Required.DisallowNull)]
		public string Secret { get; set; }
	}
}