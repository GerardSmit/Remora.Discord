//
//  PartialMessage.cs
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
using System.Collections.Generic;
using JetBrains.Annotations;
using Remora.Discord.API.Abstractions.Objects;
using Remora.Discord.Core;

#pragma warning disable CS1591

namespace Remora.Discord.API.Objects
{
    /// <inheritdoc cref="IPartialMessage" />
    [PublicAPI]
    public record PartialMessage
    (
        Optional<Snowflake> ID = default,
        Optional<Snowflake> ChannelID = default,
        Optional<Snowflake> GuildID = default,
        Optional<IUser> Author = default,
        Optional<IPartialGuildMember> Member = default,
        Optional<string> Content = default,
        Optional<DateTimeOffset> Timestamp = default,
        Optional<DateTimeOffset?> EditedTimestamp = default,
        Optional<bool> IsTTS = default,
        Optional<bool> MentionsEveryone = default,
        Optional<IReadOnlyList<IUserMention>> Mentions = default,
        Optional<IReadOnlyList<Snowflake>> MentionedRoles = default,
        Optional<IReadOnlyList<IChannelMention>> MentionedChannels = default,
        Optional<IReadOnlyList<IAttachment>> Attachments = default,
        Optional<IReadOnlyList<IEmbed>> Embeds = default,
        Optional<IReadOnlyList<IReaction>> Reactions = default,
        Optional<string> Nonce = default,
        Optional<bool> IsPinned = default,
        Optional<Snowflake> WebhookID = default,
        Optional<MessageType> Type = default,
        Optional<IMessageActivity> Activity = default,
        Optional<IPartialApplication> Application = default,
        Optional<IMessageReference> MessageReference = default,
        Optional<MessageFlags> Flags = default,
        Optional<IReadOnlyList<IMessageSticker>> Stickers = default,
        Optional<IMessage?> ReferencedMessage = default,
        Optional<IMessageInteraction> Interaction = default
    ) : IPartialMessage;
}
