using System;
using static PKHeX.Core.ItemStorage3RS;

namespace PKHeX.Core;

/// <summary>
/// Item storage for <see cref="GameVersion.E"/>
/// </summary>
public sealed class ItemStorage3E : IItemStorage
{
    public static readonly ItemStorage3E Instance = new();

    public static ReadOnlySpan<ushort> Key =>
    [
        // R/S
        259, 260, 261, 262, 263, 264, 265, 266, 268, 269, 270, 271, 272, 273, 274, 275, 276, 277, 278, 279, 280, 281, 282, 283, 284, 285, 286, 287, 288,
        // FR/LG
        349, 350, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374,
        // E
        375, 376,
    ];

    private static readonly ushort[] PCItems = [..General, ..Key, ..Balls, ..Machine, ..Berry];

    public bool IsLegal(InventoryType type, int itemIndex, int itemCount) => true;

    public ReadOnlySpan<ushort> GetItems(InventoryType type) => type switch
    {
        InventoryType.Items => General,
        InventoryType.KeyItems => Key,
        InventoryType.Balls => Balls,
        InventoryType.TMHMs => Machine,
        InventoryType.Berries => Berry,
        InventoryType.PCItems => PCItems,
        _ => throw new ArgumentOutOfRangeException(nameof(type), type, null),
    };
}
