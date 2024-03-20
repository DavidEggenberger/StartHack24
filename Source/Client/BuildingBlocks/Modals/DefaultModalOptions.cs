using Blazored.Modal;

namespace Client.BuildingBlocks.Modals
{
    public class DefaultModalOptions
    {
        public static ModalOptions Modal
        {
            get
            {
                return new ModalOptions 
                { 
                    OverlayCustomClass = "modaloverlay", 
                    Position = ModalPosition.Middle,
                    HideCloseButton = true,
                    HideHeader = true
                };
            }
        }
    }
}
