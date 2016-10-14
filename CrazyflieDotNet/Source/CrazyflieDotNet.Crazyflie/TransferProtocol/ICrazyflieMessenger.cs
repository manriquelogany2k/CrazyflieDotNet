using System;

namespace CrazyflieDotNet.Crazyflie.TransferProtocol
{
	/// <summary>
	/// Crazyflie messenger.
	/// </summary>
	public interface ICrazyflieMessenger
	{
		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <returns>The message.</returns>
		/// <param name="packet">Packet.</param>
		/// <typeparam name="TPacket">The 1st type parameter.</typeparam>
		IAckPacket SendMessage<TPacket>(TPacket packet) where TPacket : IProvideBytes;

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <returns>The message.</returns>
		/// <param name="packet">Packet.</param>
		/// <param name="ackPayloadBuilder">Ack payload builder.</param>
		/// <typeparam name="TAckPacketPayload">The 1st type parameter.</typeparam>
		IAckPacket<TAckPacketPayload> SendMessage<TAckPacketPayload>(IPacket packet, BuildAckPayload<TAckPacketPayload> ackPayloadBuilder = null) where TAckPacketPayload : IProvideBytes;
	}
}