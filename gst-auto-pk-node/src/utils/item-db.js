const fs = require('fs');
const path = require('path');

const MAGIC_NAMES = {
  26: "Sát thương vật lý ngoại công (%)",
  27: "Sát thương vật lý nội công (%)",
  28: "Ngũ hành tương khắc (%)",
  29: "Sát thương vật lý nội công",
  30: "Sát thương vật lý nội công (khoảng)",
  31: "Sát thương vật lý ngoại công",
  32: "Sát thương vật lý ngoại công (khoảng)",
  33: "Độc sát nội công",
  34: "Độc sát ngoại công",
  35: "Lôi sát nội công",
  36: "Lôi sát nội công (khoảng)",
  37: "Lôi sát ngoại công",
  38: "Lôi sát ngoại công (khoảng)",
  39: "Băng sát nội công",
  40: "Băng sát nội công (khoảng)",
  41: "Băng sát ngoại công",
  42: "Băng sát ngoại công (khoảng)",
  43: "Hỏa sát nội công",
  44: "Hỏa sát nội công (khoảng)",
  45: "Hỏa sát ngoại công",
  46: "Hỏa sát ngoại công (khoảng)",
  47: "Hỏa sát tối đa (%)",
  48: "Độ chính xác",
  49: "Độ chính xác (%)",
  50: "Bỏ qua né tránh (%)",
  51: "Tốc độ đánh nội công (%)",
  52: "Tốc độ đánh ngoại công (%)",
  53: "Né tránh",
  54: "Né tránh (%)",
  55: "Tốc độ di chuyển (%)",
  56: "Phản đòn cận chiến",
  57: "Phản đòn cận chiến (%)",
  58: "Kháng tất cả (%)",
  59: "Hút sinh lực (%)",
  60: "Hút nội lực (%)",
  61: "Sinh lực tối đa",
  62: "Sinh lực tối đa (%)",
  63: "Nội lực tối đa",
  64: "Nội lực tối đa (%)",
  65: "Thể lực tối đa",
  66: "Thể lực tối đa (%)",
  67: "Phục hồi sinh lực",
  68: "Tăng phục hồi sinh lực (%)",
  69: "Phục hồi nội lực",
  70: "Phục hồi thể lực",
  71: "Sức mạnh",
  72: "Thân pháp",
  73: "Sinh khí",
  74: "Nội công",
  75: "Chuyển hóa sát thương thành nội lực (%)",
  76: "Phòng thủ vật lý (%)",
  77: "Kháng độc (%)",
  78: "Kháng băng (%)",
  79: "Kháng hỏa (%)",
  80: "Kháng lôi (%)",
  81: "Kháng tất cả tối đa (%)",
  82: "Phòng thủ vật lý tối đa (%)",
  83: "Kháng độc tối đa (%)",
  84: "Kháng băng tối đa (%)",
  85: "Kháng hỏa tối đa (%)",
  86: "Kháng lôi tối đa (%)",
  87: "Thời gian phục hồi",
  88: "Thời gian choáng (%)",
  89: "Thời gian trúng độc (%)",
  92: "Thời gian làm chậm (%)",
  94: "May mắn (%)",
  95: "Yêu cầu thân pháp",
  96: "Yêu cầu sinh khí",
  97: "Đẳng cấp yêu cầu",
  98: "Yêu cầu sức mạnh",
  109: "Độ bền",
  114: "Thuộc tính ngũ hành",
  117: "Không thể phá hủy",
  118: "Tấn công chí mạng (%)",
  119: "Tăng tấn công chí mạng (%)",
  121: "Phản đòn tầm xa (%)"
};

const SERIES_NAMES = {
  0: "Không",
  1: "Kim",
  2: "Mộc",
  3: "Thủy",
  4: "Hỏa",
  5: "Thổ"
};

// Memory Genre/Detail to TXT JSON File Map
const FILE_MAP = {
  // genre: { detail: 'filename' }
  0: { 0: 'item_meleeweapon.json', 1: 'item_rangeweapon.json' },
  1: { 0: 'item_helm.json', 1: 'item_armor.json', 2: 'item_belt.json', 3: 'item_boot.json', 4: 'item_cuff.json' },
  2: { 0: 'item_amulet.json', 1: 'item_ring.json', 2: 'item_pendant.json', 3: 'item_pendant.json' }
};

class ItemDB {
  constructor() {
    this.cache = {};
  }

  getJsonData(filename) {
    if (this.cache[filename]) return this.cache[filename];
    try {
      const fullPath = path.join(__dirname, '..', '..', 'data', 'output', 'json', filename);
      if (fs.existsSync(fullPath)) {
        const raw = fs.readFileSync(fullPath, 'utf8');
        this.cache[filename] = JSON.parse(raw);
        return this.cache[filename];
      }
    } catch (err) {
      console.error(`Error loading JSON ${filename}:`, err.message);
    }
    return null;
  }

  getItemConfig(detailAndGenre, particular) {
    const genre = detailAndGenre >> 16;
    const detail = detailAndGenre & 0xFFFF;
    
    if (FILE_MAP[genre] && FILE_MAP[genre][detail]) {
      const filename = FILE_MAP[genre][detail];
      const data = this.getJsonData(filename);
      if (data) {
        // Find item by particular value. TXT 'particular' is typically at index "3".
        return data.find(i => parseInt(i['3']) === particular);
      }
    }
    return null;
  }

  getGenderStr(genderCode) {
    if (genderCode === 0) return 'Nam';
    if (genderCode === 1) return 'Nữ';
    return 'Không yêu cầu';
  }

  parseItem(item) {
    const level = item.particularAndLevel & 0xFF;
    const particular = (item.particularAndLevel >> 16) & 0xFFFF;
    const seriesVal = item.stackAndSeries & 0x7;
    const seriesText = SERIES_NAMES[seriesVal] || 'Không';
    
    let gender = 'Chưa rõ';
    
    // Look up DB
    const cfg = this.getItemConfig(item.detailAndGenre, particular);
    if (cfg) {
      if (cfg['giới_tính'] !== undefined && cfg['giới_tính'] !== '') {
        gender = this.getGenderStr(parseInt(cfg['giới_tính']));
      } else if (cfg['43'] !== undefined && cfg['43'] !== '') {
        gender = this.getGenderStr(parseInt(cfg['43']));
      } else {
        gender = 'Không yêu cầu';
      }
    } else {
      // Fallback logic
      if (item.name.includes('Nam') || item.name.toLowerCase().includes('nam')) gender = 'Nam';
      else if (item.name.includes('Nữ') || item.name.toLowerCase().includes('nữ')) gender = 'Nữ';
      else gender = 'Không yêu cầu';
    }

    let magicLines = [];
    if (item.magics && item.magics.length > 0) {
      for (let m = 0; m < item.magics.length; m += 2) {
        const attrId = item.magics[m];
        const attrVal = item.magics[m + 1];
        if (attrId > 0) {
          const attrName = MAGIC_NAMES[attrId] || `Mã thuộc tính ${attrId}`;
          magicLines.push(`${attrName}: +${attrVal}`);
        }
      }
    }

    return {
      name: item.name,
      level: level,
      priceVan: item.money,
      priceKnb: item.knb,
      gender: gender,
      series: seriesText,
      magicLines: magicLines
    };
  }
}

module.exports = {
  ItemDB: new ItemDB(),
  MAGIC_NAMES,
  SERIES_NAMES
};
