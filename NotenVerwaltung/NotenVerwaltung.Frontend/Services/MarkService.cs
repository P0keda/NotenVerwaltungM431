using NotenVerwaltung.Frontend.DTOs;

namespace NotenVerwaltung.Frontend.Services
{
    public class MarkService
    {
        private List<MarkAdjustmentDTO> _adjustments = new();
        private int _nextId = 1;

        public async Task<List<MarkAdjustmentDTO>> GetAdjustmentsAsync()
        {
            await Task.Delay(200);
            return _adjustments.OrderByDescending(a => a.RequestDate).ToList();
        }

        public async Task AddAdjustmentAsync(MarkAdjustmentDTO adjustment)
        {
            await Task.Delay(200);
            adjustment.Id = _nextId++;
            _adjustments.Add(adjustment);
        }
    }
}