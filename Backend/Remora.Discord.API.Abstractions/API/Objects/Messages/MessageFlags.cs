//
//  MessageFlags.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2017 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using JetBrains.Annotations;

namespace Remora.Discord.API.Abstractions.Objects
{
    /// <summary>
    /// Enumerates various message flags.
    /// </summary>
    [Flags, PublicAPI]
    public enum MessageFlags
    {
        /// <summary>
        /// The message has been published to subscribed channels.
        /// </summary>
        Crossposted = 1 << 0,

        /// <summary>
        /// The message originated from a message in another channel.
        /// </summary>
        IsCrosspost = 1 << 1,

        /// <summary>
        /// No embeds should be included when serializing the message.
        /// </summary>
        SuppressEmbeds = 1 << 2,

        /// <summary>
        /// The source message for this crosspost has been deleted.
        /// </summary>
        SourceMessageDeleted = 1 << 3,

        /// <summary>
        /// This message came from the urgent message system.
        /// </summary>
        Urgent = 1 << 4,

        /// <summary>
        /// The message will only be visible to the executing user.
        /// </summary>
        Ephemeral = 1 << 6,

        /// <summary>
        /// The message is a loading message, created by an interaction response (typically, this shows that the bot is
        /// "thinking".)
        /// </summary>
        Loading = 1 << 6
    }
}
