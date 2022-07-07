﻿/// <summary>
///   Types of tutorial events sent to the tutorial system
/// </summary>
public enum TutorialEventType
{
    /// <summary>
    ///   Player object was created, args is <see cref="MicrobeEventArgs"/>
    /// </summary>
    MicrobePlayerSpawned,

    /// <summary>
    ///   Rotation of the player in the microbe stage, args is <see cref="RotationEventArgs"/>
    /// </summary>
    MicrobePlayerOrientation,

    /// <summary>
    ///   There are tutorial relevant compounds near the player, args is <see cref="EntityPositionEventArgs"/>
    /// </summary>
    MicrobeCompoundsNearPlayer,

    /// <summary>
    ///   There are tutorial relevant chunk near the player, args is <see cref="EntityPositionEventArgs"/>
    /// </summary>
    MicrobeChunksNearPlayer,

    /// <summary>
    ///   Reports the player compound amounts while they are alive, args is <see cref="CompoundBagEventArgs"/>
    /// </summary>
    MicrobePlayerCompounds,

    /// <summary>
    ///   Reports total compounds the player has absorbed, args is <see cref="CompoundEventArgs"/>
    /// </summary>
    MicrobePlayerTotalCollected,

    /// <summary>
    ///   Player cell engulfment storage has reached full capacity
    /// </summary>
    MicrobePlayerEngulfmentFull,

    /// <summary>
    ///   The player has been engulfed by a hostile and larger microbe
    /// </summary>
    MicrobePlayerIsEngulfed,

    /// <summary>
    ///   The player has engulfed an engulfable object
    /// </summary>
    MicrobePlayerEngulfing,

    /// <summary>
    ///   Player has died
    /// </summary>
    MicrobePlayerDied,

    /// <summary>
    ///   Player is ready to reproduce
    /// </summary>
    MicrobePlayerReadyToEdit,

    /// <summary>
    ///   Player entered the microbe stage
    /// </summary>
    EnteredMicrobeStage,

    /// <summary>
    ///   Player entered the microbe editor
    /// </summary>
    EnteredMicrobeEditor,

    /// <summary>
    ///   Player changed the microbe editor tab, args is <see cref="StringEventArgs"/>
    /// </summary>
    MicrobeEditorTabChanged,

    /// <summary>
    ///   Player selected a patch in the microbe editor, args is <see cref="PatchEventArgs"/>
    /// </summary>
    MicrobeEditorPatchSelected,

    /// <summary>
    ///   Player selected an organelle to place in the editor, args is <see cref="StringEventArgs"/>
    /// </summary>
    MicrobeEditorOrganelleToPlaceChanged,

    /// <summary>
    ///   Player placed an organelle
    /// </summary>
    MicrobeEditorOrganellePlaced,

    /// <summary>
    ///   Player undid an action in the editor
    /// </summary>
    MicrobeEditorUndo,

    /// <summary>
    ///   Player redid an action in the editor
    /// </summary>
    MicrobeEditorRedo,

    /// <summary>
    ///   The player pressed Shift+U to toggle enable unbind mode
    /// </summary>
    MicrobePlayerUnbindEnabled,

    /// <summary>
    ///   The player unbound any cell
    /// </summary>
    MicrobePlayerUnbound,

    /// <summary>
    ///   Player opened the auto-evo prediction details
    /// </summary>
    MicrobeEditorAutoEvoPredictionOpened,
}
