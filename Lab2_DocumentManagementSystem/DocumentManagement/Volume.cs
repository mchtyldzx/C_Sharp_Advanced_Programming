using System;
using DocumentManagement.Exceptions;

namespace DocumentManagement
{
    public class Volume : Document
    {
        public int VolumeNumber { get; set; }
        public int TotalVolumes { get; set; }

        public Volume() : base()
        {
        }

        public Volume(string isbn, string title, int publicationYear, int pageCount, int volumeNumber, int totalVolumes)
            : base(isbn, title, publicationYear, pageCount)
        {
            if (volumeNumber > totalVolumes)
            {
                throw new VolumeNumberExceedsTotalException($"Volume number ({volumeNumber}) cannot be greater than total volumes ({totalVolumes})");
            }
            VolumeNumber = volumeNumber;
            TotalVolumes = totalVolumes;
        }

        public override string Print()
        {
            return $"Printing volume {VolumeNumber} of {TotalVolumes}: {Title}";
        }

        public override string ToString()
        {
            return $"Volume - {base.ToString()}, Volume: {VolumeNumber}/{TotalVolumes}";
        }
    }
} 
