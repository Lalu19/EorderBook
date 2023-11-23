namespace AdminApi.DTO.App.BeatMasterDTO
{
    public class CreateBeatDTO
    {
        public int AreaId { get; set; }
        public string BeatName { get; set; }
        public int CreatedBy { get; set; }
    }

    public class UpdateBeatDTO
    {
        public int AreaId { get; set; }
        public int BeatId { get; set; }
        public string BeatName { get; set; }
        public int CreatedBy { get; set; }
    }
}
