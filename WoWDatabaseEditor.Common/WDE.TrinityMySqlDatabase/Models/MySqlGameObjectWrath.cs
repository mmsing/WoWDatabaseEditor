using LinqToDB.Mapping;
using WDE.Common.Database;

namespace WDE.TrinityMySqlDatabase.Models
{
    [Table(Name = "gameobject")]
    public class MySqlGameObjectWrath : IGameObject
    {
        [PrimaryKey]
        [Identity]
        [Column(Name = "guid")]
        public uint Guid { get; set; }

        [Column(Name = "id")]
        public uint Entry { get; set; }
        [Column(Name = "map")]
        public uint Map { get; set; }

        public int? PhaseId => null;
        
        public int? PhaseGroup => null;
        
        [Column(Name = "phaseMask")]
        public uint? PhaseMask { get; set; }

        [Column(Name = "position_x")]
        public float X { get; set; }

        [Column(Name = "position_y")]
        public float Y { get; set; }

        [Column(Name = "position_z")]
        public float Z { get; set; }

        [Column(Name = "orientation")]
        public float Orientation { get; set; }

        [Column(Name = "rotation0")]
        public float Rotation0 { get; set; }

        [Column(Name = "rotation1")]
        public float Rotation1 { get; set; }

        [Column(Name = "rotation2")]
        public float Rotation2 { get; set; }

        [Column(Name = "rotation3")]
        public float Rotation3 { get; set; }

        // in addon
        //[Column(Name = "parent_rotation0")]
        public float ParentRotation0 { get; set; }

        //[Column(Name = "parent_rotation1")]
        public float ParentRotation1 { get; set; }

        //[Column(Name = "parent_rotation2")]
        public float ParentRotation2 { get; set; }

        //[Column(Name = "parent_rotation3")]
        public float ParentRotation3 { get; set; }
    }
    
    
    [Table(Name = "gameobject")]
    public class MySqlGameObjectCata : IGameObject
    {
        [PrimaryKey]
        [Identity]
        [Column(Name = "guid")]
        public uint Guid { get; set; }

        [Column(Name = "id")]
        public uint Entry { get; set; }
        [Column(Name = "map")]
        public uint Map { get; set; }

        public uint? PhaseMask => null;
        
        [Column(Name = "PhaseId")]
        public int? PhaseId { get; set; }
        
        [Column(Name = "PhaseGroup")]
        public int? PhaseGroup { get; set; }

        [Column(Name = "position_x")]
        public float X { get; set; }

        [Column(Name = "position_y")]
        public float Y { get; set; }

        [Column(Name = "position_z")]
        public float Z { get; set; }

        [Column(Name = "orientation")]
        public float Orientation { get; set; }

        [Column(Name = "rotation0")]
        public float Rotation0 { get; set; }

        [Column(Name = "rotation1")]
        public float Rotation1 { get; set; }

        [Column(Name = "rotation2")]
        public float Rotation2 { get; set; }

        [Column(Name = "rotation3")]
        public float Rotation3 { get; set; }

        // in addon
        //[Column(Name = "parent_rotation0")]
        public float ParentRotation0 { get; set; }

        //[Column(Name = "parent_rotation1")]
        public float ParentRotation1 { get; set; }

        //[Column(Name = "parent_rotation2")]
        public float ParentRotation2 { get; set; }

        //[Column(Name = "parent_rotation3")]
        public float ParentRotation3 { get; set; }
    }
}