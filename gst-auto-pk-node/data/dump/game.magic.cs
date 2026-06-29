// Image 0: mscorlib.dll - 0
// Image 1: Assembly-CSharp.dll - 1689
// Image 2: System.Xml.dll - 3042
// Image 3: System.dll - 3711
// Image 4: System.Data.dll - 4409
// Image 5: Google.Protocol.dll - 4647
// Image 6: Unity.TextMeshPro.dll - 5135
// Image 7: System.Core.dll - 5332
// Image 8: Newtonsoft.Json.dll - 5981
// Image 9: Google.Protobuf.dll - 6286
// Image 10: UnityEngine.CoreModule.dll - 6582
// Image 11: UnityEngine.UI.dll - 7226
// Image 12: UnityEngine.TextCoreTextEngineModule.dll - 7421
// Image 13: Mono.Security.dll - 7515
// Image 14: UnityEngine.AndroidJNIModule.dll - 7600
// Image 15: System.IO.Compression.dll - 7645
// Image 16: I18N.West.dll - 7705
// Image 17: UnityEngine.IMGUIModule.dll - 7739
// Image 18: System.Drawing.dll - 7776
// Image 19: UnityEngine.TextCoreFontEngineModule.dll - 7787
// Image 20: I18N.dll - 7812
// Image 21: System.Numerics.dll - 7825
// Image 22: System.Xml.Linq.dll - 7838
// Image 23: UnityEngine.PropertiesModule.dll - 7876
// Image 24: UnityEngine.dll - 7934
// Image 25: deml.netcore-networking.dll - 7935
// Image 26: UnityEngine.UnityWebRequestModule.dll - 7949
// Image 27: UnityEngine.UIModule.dll - 7968
// Image 28: UnityEngine.AnimationModule.dll - 7979
// Image 29: UnityEngine.TextRenderingModule.dll - 8011
// Image 30: UnityEngine.Physics2DModule.dll - 8025
// Image 31: UnityEngine.InputLegacyModule.dll - 8035
// Image 32: UnityEngine.AudioModule.dll - 8046
// Image 33: UnityEngine.SharedInternalsModule.dll - 8065
// Image 34: UnityEngine.AssetBundleModule.dll - 8093
// Image 35: UnityEngine.ImageConversionModule.dll - 8099
// Image 36: UnityEngine.AIModule.dll - 8101
// Image 37: UnityEngine.SpriteShapeModule.dll - 8104
// Image 38: System.IO.Compression.FileSystem.dll - 8106
// Image 39: CandyCoded.HapticFeedback.Android.dll - 8110
// Image 40: System.Runtime.Serialization.dll - 8118
// Image 41: CandyCoded.HapticFeedback.dll - 8123
// Image 42: System.Runtime.CompilerServices.Unsafe.dll - 8131
// Image 43: System.Configuration.dll - 8134
// Image 44: __Generated - 8144

// Namespace: game.magic
public class Attrib // TypeDefIndex: 2053
{
	// Fields
	public string type; // 0x10
	public int[] value; // 0x18
	public static readonly Attrib Empty; // 0x0
	private static readonly Dictionary<int, string> StringMapping; // 0x8

	// Methods

	// RVA: 0xF82C78 Offset: 0xF7EC78 VA: 0xF82C78
	public void .ctor() { }

	// RVA: 0xF82D44 Offset: 0xF7ED44 VA: 0xF82D44
	public void .ctor(Attrib orther) { }

	// RVA: 0xF82EC0 Offset: 0xF7EEC0 VA: 0xF82EC0
	public void .ctor(MagicAttrib magicAttrib) { }

	// RVA: 0xF82FE8 Offset: 0xF7EFE8 VA: 0xF82FE8
	public void .ctor(string type, int v1) { }

	// RVA: 0xF8312C Offset: 0xF7F12C VA: 0xF8312C
	public void .ctor(string type, int v1, int v2) { }

	// RVA: 0xF83280 Offset: 0xF7F280 VA: 0xF83280
	public MagicAttrib ToAppMagicAttrib() { }

	// RVA: 0xF83318 Offset: 0xF7F318 VA: 0xF83318
	public void PushBack(int value) { }

	// RVA: 0xF83410 Offset: 0xF7F410 VA: 0xF83410
	public int Get(int index) { }

	// RVA: 0xF8344C Offset: 0xF7F44C VA: 0xF8344C
	public void Set(int index, int value) { }

	// RVA: 0xF834D0 Offset: 0xF7F4D0 VA: 0xF834D0
	public void Append(Attrib other) { }

	// RVA: 0xF8356C Offset: 0xF7F56C VA: 0xF8356C
	public void Detach(Attrib other) { }

	// RVA: 0xF8360C Offset: 0xF7F60C VA: 0xF8360C
	public string String() { }

	// RVA: 0xF836CC Offset: 0xF7F6CC VA: 0xF836CC
	public static Attrib ParseSingle(string data) { }

	// RVA: 0xF83A64 Offset: 0xF7FA64 VA: 0xF83A64
	public static List<Attrib> ParseMulti(string data) { }

	// RVA: 0xF83BF8 Offset: 0xF7FBF8 VA: 0xF83BF8
	private static void .cctor() { }
}

// Namespace: game.magic
public class Description // TypeDefIndex: 2054
{
	// Methods

	// RVA: 0xF83CB4 Offset: 0xF7FCB4 VA: 0xF83CB4
	private static object GetDescribe(string format, int value) { }

	// RVA: 0xF841F0 Offset: 0xF801F0 VA: 0xF841F0
	private static object GetValue(Attrib attrib, string format, int index) { }

	// RVA: 0xF8438C Offset: 0xF8038C VA: 0xF8438C
	private static string ParseFormatTwo(Attrib attrib, string[] param) { }

	// RVA: 0xF84524 Offset: 0xF80524 VA: 0xF84524
	private static string ParseFormatThree(Attrib attrib, string[] param) { }

	// RVA: 0xF848F4 Offset: 0xF808F4 VA: 0xF848F4
	public static string Get(Attrib attrib) { }

	// RVA: 0xF84B8C Offset: 0xF80B8C VA: 0xF84B8C
	public void .ctor() { }
}

// Namespace: game.magic
public class Parse // TypeDefIndex: 2055
{
	// Methods

	// RVA: 0xF758A8 Offset: 0xF718A8 VA: 0xF758A8
	public static Skill Implement(Skill skill, string fullData) { }

	// RVA: 0xF84B94 Offset: 0xF80B94 VA: 0xF84B94
	public void .ctor() { }
}

// Namespace: 
private enum Table.HeaderIndexer // TypeDefIndex: 2056
{
	// Fields
	public int value__; // 0x0
	public const Table.HeaderIndexer type = 0;
	public const Table.HeaderIndexer reserve1 = 1;
	public const Table.HeaderIndexer description = 2;
}

// Namespace: game.magic
public class Table // TypeDefIndex: 2057
{
	// Fields
	public static Dictionary<string, string> storage; // 0x0

	// Methods

	// RVA: 0xF84B9C Offset: 0xF80B9C VA: 0xF84B9C
	public static bool Initialize(Action<string> logfunc) { }

	// RVA: 0xF84ADC Offset: 0xF80ADC VA: 0xF84ADC
	public static string Get(string type) { }

	// RVA: 0xF84DBC Offset: 0xF80DBC VA: 0xF84DBC
	public void .ctor() { }

	// RVA: 0xF84DC4 Offset: 0xF80DC4 VA: 0xF84DC4
	private static void .cctor() { }
}

// Namespace: game.magic
public static class ID // TypeDefIndex: 2058
{
	// Fields
	public static readonly Dictionary<string, int> typeToId; // 0x0
	public static readonly Dictionary<int, string> idToType; // 0x8

	// Methods

	// RVA: 0xF84E5C Offset: 0xF80E5C VA: 0xF84E5C
	private static void .cctor() { }
}

// Namespace: game.magic
public class Type // TypeDefIndex: 2059
{
	// Fields
	public const string server_prefix = "server_";
	public const string client_prefix = "client_";
	public const string ten_ky_nang = "tên_kỹ_năng";
	public const string so_luong_hinh_anh = "số_lượng_hình_ảnh";
	public const string toc_do_bay_cua_hinh_anh = "tốc_độ_bay_của_hình_ảnh";
	public const string thoi_gian_ton_tai_hinh_anh = "thời_gian_tồn_tại_hình_ảnh";
	public const string pham_vi_hieu_qua = "phạm_vi_hiệu_quả";
	public const string cho_phep_ky_nang_phu = "cho_phép_kỹ_năng_phụ";
	public const string dang_cap_ky_nang_phu = "đẳng_cấp_kỹ_năng_phụ";
	public const string ky_nang_phu_khi_bat_dau = "kỹ_năng_phụ_khi_bắt_đầu";
	public const string ky_nang_phu_khi_dang_bay = "kỹ_năng_phụ_khi_đang_bay";
	public const string ky_nang_phu_khi_va_cham = "kỹ_năng_phụ_khi_va_chạm";
	public const string ky_nang_phu_khi_ket_thuc = "kỹ_năng_phụ_khi_kết_thúc";
	public const string tieu_hao_noi_luc = "tiêu_hao_nội_lực";
	public const string tieu_hao_sinh_luc = "tiêu_hao_sinh_lực";
	public const string lam_trong_thuong = "làm_trọng_thương";
	public const string tong_kinh_nghiem_len_cap = "tổng_kinh_nghiệm_lên_cấp";
	public const string thoi_gian_hoi_chieu = "thời_gian_hồi_chiêu";
	public const string thoi_gian_hoi_chieu_tren_ngua = "thời_gian_hồi_chiêu_trên_ngựa";
	public const string thong_so_bo_sung_1 = "thông_số_bổ_sung_1";
	public const string mo_ta_ky_nang = "mô_tả_kỹ_năng";
	public const string hien_thi_hieu_qua_ky_nang = "hiển_thị_hiệu_quả_kỹ_năng";
	public const string hien_thi_ma_phap_ky_nang = "hiển_thị_ma_pháp_kỹ_năng";
	public const string hien_thi_tang_thuc_ky_nang = "hiển_thị_tầng_thức_kỹ_năng";
	public const string ty_le_danh_khong_trung_muc_tieu = "tỷ_lệ_đánh_không_trúng_mục_tiêu";
	public const string so_luong_muc_tieu_toi_da = "số_lượng_mục_tiêu_tối_đa";
	public const string sat_thuong_vat_ly_ngoai_phan_tram = "sát_thương_vật_lý_ngoại_phần_trăm";
	public const string sat_thuong_vat_ly_noi_phan_tram = "sát_thương_vật_lý_nội_phần_trăm";
	public const string ngu_hanh_tuong_khac_phan_tram = "ngũ_hành_tương_khắc_phần_trăm";
	public const string sat_thuong_vat_ly_noi = "sát_thương_vật_lý_nội";
	public const string sat_thuong_vat_ly_noi_trong_khoang = "sát_thương_vật_lý_nội_trong_khoảng";
	public const string sat_thuong_vat_ly_ngoai = "sát_thương_vật_lý_ngoại";
	public const string sat_thuong_vat_ly_ngoai_trong_khoang = "sát_thương_vật_lý_ngoại_trong_khoảng";
	public const string doc_sat_noi = "độc_sát_nội";
	public const string doc_sat_ngoai = "độc_sát_ngoại";
	public const string loi_sat_noi = "lôi_sát_nội";
	public const string loi_sat_noi_trong_khoang = "lôi_sát_nội_trong_khoảng";
	public const string loi_sat_ngoai = "lôi_sát_ngoại";
	public const string loi_sat_ngoai_trong_khoang = "lôi_sát_ngoại_trong_khoảng";
	public const string bang_sat_noi = "băng_sát_nội";
	public const string bang_sat_noi_trong_khoang = "băng_sát_nội_trong_khoảng";
	public const string bang_sat_ngoai = "băng_sát_ngoại";
	public const string bang_sat_ngoai_trong_khoang = "băng_sát_ngoại_trong_khoảng";
	public const string hoa_sat_noi = "hỏa_sát_nội";
	public const string hoa_sat_noi_trong_khoang = "hỏa_sát_nội_trong_khoảng";
	public const string hoa_sat_ngoai = "hỏa_sát_ngoại";
	public const string hoa_sat_ngoai_trong_khoang = "hỏa_sát_ngoại_trong_khoảng";
	public const string hoa_sat_toi_da_phan_tram = "hỏa_sát_tối_đa_phần_trăm";
	public const string do_chinh_xac = "độ_chính_xác";
	public const string do_chinh_xac_phan_tram = "độ_chính_xác_phần_trăm";
	public const string bo_qua_ne_tranh_phan_tram = "bỏ_qua_né_tránh_phần_trăm";
	public const string toc_do_danh_noi_phan_tram = "tốc_độ_đánh_nội_phần_trăm";
	public const string toc_do_danh_ngoai_phan_tram = "tốc_độ_đánh_ngoại_phần_trăm";
	public const string ne_tranh = "né_tránh";
	public const string ne_tranh_phan_tram = "né_tránh_phần_trăm";
	public const string toc_do_di_chuyen_phan_tram = "tốc_độ_di_chuyển_phần_trăm";
	public const string phan_don_can_chien = "phản_đòn_cận_chiến";
	public const string phan_don_can_chien_phan_tram = "phản_đòn_cận_chiến_phần_trăm";
	public const string khang_tat_ca_phan_tram = "kháng_tất_cả_phần_trăm";
	public const string hut_sinh_luc_phan_tram = "hút_sinh_lực_phần_trăm";
	public const string hut_noi_luc_phan_tram = "hút_nội_lực_phần_trăm";
	public const string sinh_luc_toi_da = "sinh_lực_tối_đa";
	public const string sinh_luc_toi_da_phan_tram = "sinh_lực_tối_đa_phần_trăm";
	public const string noi_luc_toi_da = "nội_lực_tối_đa";
	public const string noi_luc_toi_da_phan_tram = "nội_lực_tối_đa_phần_trăm";
	public const string the_luc_toi_da = "thể_lực_tối_đa";
	public const string the_luc_toi_da_phan_tram = "thể_lực_tối_đa_phần_trăm";
	public const string phuc_hoi_sinh_luc_moi_nua_giay = "phục_hồi_sinh_lực_mỗi_nửa_giây";
	public const string tang_hoi_sinh_luc_phan_tram = "tăng_hồi_sinh_lực_phần_trăm";
	public const string phuc_hoi_noi_luc_moi_nua_giay = "phục_hồi_nội_lực_mỗi_nửa_giây";
	public const string phuc_hoi_the_luc_moi_nua_giay = "phục_hồi_thể_lực_mỗi_nửa_giây";
	public const string suc_manh = "sức_mạnh";
	public const string than_phap = "thân_pháp";
	public const string sinh_khi = "sinh_khí";
	public const string noi_cong = "nội_công";
	public const string chuyen_hoa_sat_thuong_thanh_noi_luc_phan_tram = "chuyển_hóa_sát_thương_thành_nội_lực_phần_trăm";
	public const string phong_thu_vat_ly_phan_tram = "phòng_thủ_vật_lý_phần_trăm";
	public const string khang_doc_phan_tram = "kháng_độc_phần_trăm";
	public const string khang_bang_phan_tram = "kháng_băng_phần_trăm";
	public const string khang_hoa_phan_tram = "kháng_hỏa_phần_trăm";
	public const string khang_loi_phan_tram = "kháng_lôi_phần_trăm";
	public const string khang_tat_ca_toi_da_phan_tram = "kháng_tất_cả_tối_đa_phần_trăm";
	public const string phong_thu_vat_ly_toi_da_phan_tram = "phòng_thủ_vật_lý_tối_đa_phần_trăm";
	public const string khang_doc_toi_da_phan_tram = "kháng_độc_tối_đa_phần_trăm";
	public const string khang_bang_toi_da_phan_tram = "kháng_băng_tối_đa_phần_trăm";
	public const string khang_hoa_toi_da_phan_tram = "kháng_hỏa_tối_đa_phần_trăm";
	public const string khang_loi_toi_da_phan_tram = "kháng_lôi_tối_đa_phần_trăm";
	public const string thoi_gian_phuc_hoi = "thời_gian_phục_hồi";
	public const string thoi_gian_choang_phan_tram = "thời_gian_choáng_phần_trăm";
	public const string thoi_gian_trung_doc_phan_tram = "thời_gian_trúng_độc_phần_trăm";
	public const string thoi_gian_doc_phat_phan_tram = "thời_gian_độc_phát_phần_trăm";
	public const string thoi_gian_su_dung = "thời_gian_sử_dụng";
	public const string thoi_gian_lam_cham_phan_tram = "thời_gian_làm_chậm_phần_trăm";
	public const string thoi_gian_tri_hoan_bang_sat_phan_tram = "thời_gian_trì_hoãn_phần_trăm";
	public const string may_man_phan_tram = "may_mắn_phần_trăm";
	public const string yeu_cau_than_phap = "yêu_cầu_thân_pháp";
	public const string yeu_cau_sinh_khi = "yêu_cầu_sinh_khí";
	public const string dang_cap_yeu_cau = "đẳng_cấp_yêu_cầu";
	public const string yeu_cau_suc_manh = "yêu_cầu_sức_mạnh";
	public const string yeu_cau_ky_nang_1 = "yêu_cầu_kỹ_năng_1";
	public const string yeu_cau_ky_nang_2 = "yêu_cầu_kỹ_năng_2";
	public const string yeu_cau_ky_nang_3 = "yêu_cầu_kỹ_năng_3";
	public const string yeu_cau_ky_nang_4 = "yêu_cầu_kỹ_năng_4";
	public const string yeu_cau_ky_nang_5 = "yêu_cầu_kỹ_năng_5";
	public const string yeu_cau_ky_nang_6 = "yêu_cầu_kỹ_năng_6";
	public const string yeu_cau_ky_nang_7 = "yêu_cầu_kỹ_năng_7";
	public const string yeu_cau_ky_nang_8 = "yêu_cầu_kỹ_năng_8";
	public const string yeu_cau_ky_nang_9 = "yêu_cầu_kỹ_năng_9";
	public const string yeu_cau_ky_nang_10 = "yêu_cầu_kỹ_năng_10";
	public const string do_ben = "độ_bền";
	public const string sat_thuong_lon_nhat = "sát_thương_lớn_nhất";
	public const string sat_thuong_nho_nhat = "sát_thương_nhỏ_nhất";
	public const string gioi_tinh = "giới_tính";
	public const string so_lan_su_dung = "số_lần_sử_dụng";
	public const string thuoc_tinh_ngu_hanh = "thuộc_tính_ngũ_hành";
	public const string mon_phai = "môn_phái";
	public const string tang_cap_ky_nang = "tăng_cấp_kỹ_năng";
	public const string khong_the_pha_huy = "không_thể_phá_hủy";
	public const string tan_cong_chi_mang_phan_tram = "tấn_công_chí_mạng_phần_trăm";
	public const string tang_tan_cong_chi_mang_phan_tram = "tăng_tấn_công_chí_mạng_phần_trăm";
	public const string tan_cong_chi_tu_phan_tram = "tấn_công_chí_tử_phần_trăm";
	public const string phan_don_tam_xa_phan_tram = "phản_đòn_tầm_xa_phần_trăm";
	public const string sat_thuong_dich_nhan_duoc_kinh_nghiem_phan_tram = "sát_thương_địch_nhận_được_kinh_nghiệm_phần_trăm";
	public const string ho_tro_ky_nang_1_phan_tram = "hỗ_trợ_kỹ_năng_1_phần_trăm";
	public const string ho_tro_ky_nang_2_phan_tram = "hỗ_trợ_kỹ_năng_2_phần_trăm";
	public const string ho_tro_ky_nang_3_phan_tram = "hỗ_trợ_kỹ_năng_3_phần_trăm";
	public const string ho_tro_ky_nang_4_phan_tram = "hỗ_trợ_kỹ_năng_4_phần_trăm";
	public const string ho_tro_ky_nang_5_phan_tram = "hỗ_trợ_kỹ_năng_5_phần_trăm";
	public const string ho_tro_ky_nang_6_phan_tram = "hỗ_trợ_kỹ_năng_6_phần_trăm";
	public const string lam_choang_phan_tram = "làm_choáng_phần_trăm";
	public const string bat_diet_kim_than = "bất_diệt_kim_thân";
	public const string noi_luc_ho_than_phan_tram = "nội_lực_hộ_thân_phần_trăm";
	public const string noi_luc_ho_than_diem = "nội_lực_hộ_thân_điểm";
	public const string khang_phan_don_phan_tram = "kháng_phản_đòn_phần_trăm";
	public const string xac_suat_bo_qua_bua_giam_khang_phan_tram = "xs_bỏ_qua_bùa_giảm_kháng_p";
	public const string phan_don_khi_bi_trung_doc_phan_tram = "phản_đòn_khi_bị_trúng_độc_p";
	public const string xac_suat_phan_don_bua_chu_phan_tram = "xs_phản_đòn_bùa_chú_p";
	public const string bo_qua_trang_thai_di_thuong_phan_tram = "bỏ_qua_trạng_thái_dị_thường_phần_trăm";
	public const string tu_dong_phan_hoi_khi_bi_danh = "tự_phản_hồi_khi_bị_đánh";
	public const string tu_danh_khi_xuat_chieu = "tự_đánh_khi_xuất_chiêu";
	public const string tu_danh_khi_bi_ha_guc = "tự_đánh_khi_bị_hạ_gục";
	public const string tu_danh_khi_mau_thap_hon_25_phan_tram = "tự_đánh_khi_máu_thấp_hơn_25_phần_trăm";
	public const string ha_doc_giam_noi_luc_phan_tram = "hạ_độc_giảm_nội_lực_phần_trăm";
	public const string lay_thong_so_thap_nhat_tu_ky_nang_1 = "lấy_thông_số_thấp_nhất_từ_kỹ_năng_1";
	public const string lay_thong_so_thap_nhat_tu_ky_nang_2 = "lấy_thông_số_thấp_nhất_từ_kỹ_năng_2";
	public const string lay_thong_so_thap_nhat_tu_ky_nang_3 = "lấy_thông_số_thấp_nhất_từ_kỹ_năng_3";
	public const string lay_thong_so_thap_nhat_tu_ky_nang_4 = "lấy_thông_số_thấp_nhất_từ_kỹ_năng_4";
	public const string lay_thong_so_thap_nhat_tu_ky_nang_5 = "lấy_thông_số_thấp_nhất_từ_kỹ_năng_5";
	public const string an_than_tam_thoi = "ẩn_thân_tạm_thời";
	public const string an_than_vinh_vien = "ẩn_thân_vĩnh_viễn";
	public const string hoang_loan = "hoảng_loạn";
	public const string noi_luc_chong_do_sat_thuong_phan_tram = "nội_lực_chống_đỡ_sát_thương_phần_trăm";
	public const string triet_tieu_sat_thuong_quai = "triệt_tiêu_sát_thương_quái";
	public const string triet_tieu_sat_thuong_nguoi = "triệt_tiêu_sát_thương_người";

	// Methods

	// RVA: 0xF877F8 Offset: 0xF837F8 VA: 0xF877F8
	public void .ctor() { }
}
