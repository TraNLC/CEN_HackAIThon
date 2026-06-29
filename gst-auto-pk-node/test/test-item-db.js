const { ItemDB } = require('../src/utils/item-db');

const mockItems = [
  {
    name: 'Tăng y (Nam)',
    money: 1500,
    knb: 0,
    detailAndGenre: (1 << 16) | 1, // Armor
    particularAndLevel: (1 << 16) | 60, // particular = 1 (Tăng y), level = 60
    stackAndSeries: 1, // Kim
    magics: [26, 50, 59, 5] // Sát thương vật lý ngoại công +50, Hút sinh lực +5
  },
  {
    name: 'Kiếm Vô Danh',
    money: 0,
    knb: 100,
    detailAndGenre: (0 << 16) | 0, // Melee Weapon
    particularAndLevel: (0 << 16) | 90, // particular = 0 (Cang Kiếm), level = 90
    stackAndSeries: 4, // Hỏa
    magics: []
  }
];

console.log("=== MOCK TESTING ITEMS ===");

mockItems.forEach((item, idx) => {
  const parsedItem = ItemDB.parseItem(item);

  console.log(`tên item: ${parsedItem.name}`);
  console.log(`cấp: ${parsedItem.level}`);
  if (parsedItem.priceVan > 0) {
    console.log(`giá vạn: ${parsedItem.priceVan}`);
  }
  if (parsedItem.priceKnb > 0) {
    console.log(`giá KNB: ${parsedItem.priceKnb}`);
  }
  console.log(`giới tính: ${parsedItem.gender}`);
  console.log(`ngũ hành: ${parsedItem.series}`);
  
  if (parsedItem.magicLines.length > 0) {
    console.log(`thuộc tính từng dòng như hình (có tối đa 6 dòng):`);
    parsedItem.magicLines.forEach(line => console.log(`- ${line}`));
  } else {
    console.log(`thuộc tính từng dòng như hình (có tối đa 6 dòng): Không có`);
  }
  console.log('---------------------------------------');
});
