using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }
        int flagvn = 0;
        int flagen = 0;
        int flagedm = 0;
        public DataTable VN = new DataTable();
        public DataTable EN = new DataTable();
        public DataTable EDM = new DataTable();
        public DataTable Like = new DataTable();
        public DataTable Playlist = new DataTable();
        string FileSave;
        WebClient Wc = new WebClient();
        private void SaveFile()
        {
            SaveFileDialog saveDial = new SaveFileDialog();
            saveDial.Title = "Download music";
            saveDial.Filter = ".mp3|*.mp3";
            if (saveDial.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                FileSave = saveDial.FileName;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            VNLoad();
            ENLoad();
            EDMLoad();
            LikeLoad();
            PlaylistLoad();
        }
        private void LikeLoad()
        {
            Like.Columns.Add("theloai", typeof(string));
            Like.Columns.Add("hinhanh", typeof(object));
            Like.Columns.Add("liked", typeof(string));
            Like.Columns.Add("tenbaihat", typeof(string));
            Like.Columns.Add("tencasi", typeof(string));
            Like.Columns.Add("thoiluong", typeof(string));
            Like.Columns.Add("binhluan", typeof(string));
            Like.Columns.Add("baihat", typeof(string));
            Like.Columns.Add("loibaihat", typeof(string));
        }
        private void PlaylistLoad()
        {
            Playlist.Columns.Add("theloai", typeof(string));
            Playlist.Columns.Add("hinhanh", typeof(object));
            Playlist.Columns.Add("liked", typeof(string));
            Playlist.Columns.Add("tenbaihat", typeof(string));
            Playlist.Columns.Add("tencasi", typeof(string));
            Playlist.Columns.Add("thoiluong", typeof(string));
            Playlist.Columns.Add("binhluan", typeof(string));
            Playlist.Columns.Add("baihat", typeof(string));
            Playlist.Columns.Add("loibaihat", typeof(string));
        }
        private void VNLoad()
        {
            VN.Columns.Add("theloai", typeof(string));
            VN.Columns.Add("hinhanh", typeof(object));
            VN.Columns.Add("liked", typeof(string));
            VN.Columns.Add("tenbaihat", typeof(string));
            VN.Columns.Add("tencasi", typeof(string));
            VN.Columns.Add("thoiluong", typeof(string));
            VN.Columns.Add("binhluan", typeof(string));
            VN.Columns.Add("baihat", typeof(string));
            VN.Columns.Add("loibaihat", typeof(string));
            // the loai - hinh anh -ten bai hat - ten ca si - thoi luong - bai hat - lyric

            VN.Rows.Add("VN", Properties.Resources.ACA, 0, "#AiChoAi", "FloD", "2:40", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN FloD -  #AiChoAi.wav", "Sớm mai tỉnh dậy tôi lạc vào hư không\r\nĐôi tay níu lấy điều gì mà chờ mong\r\nNắng kéo mây về\r\nGió kéo đông về\r\nBuồn người thương kéo tôi về ngày yêu\r\nĐêm qua mơ thấy anh quay về\r\nÔm choàng nhau ấm áp đông qua\r\nThức giấc môi cười\r\nÔi là mơ thôi\r\nBuồn tôi ơi khi nào mày vơi\r\nAnh cứ đi đi tìm tình yêu mới\r\nTôi đứng đây ôm trọn tình yêu cũ\r\nNhắn gió mây gửi đến anh đôi lời\r\nSợi tơ duyên đứt đi rồi có nối lại được không\r\nAh anh chẳng thể nắm được duyên tình mặc dù luôn muốn giữ em cho riêng mình\r\nAnh chẳng thể giữ em lại đây mặc dù cô đơn vẫn cứ luôn bủa vây\r\nAnh biết trước hai ta phải xa nhau\r\nThêm lâu rồi niềm đau sẽ thêm sâu\r\nNhưng nếu ta xa nhau thì con tim này ai khâu\r\nAnh biết thời gian rồi vẫn qua\r\nThanh xuân cả hai rồi sẽ qua\r\nNhưng có những thứ cả hai chẳng thể xoá\r\nEm tồn tại trong anh là giấc mơ\r\nAnh đã tìm được em trong nỗi nhớ\r\nNhưng anh sống với hiện thực\r\nTình yêu còn đó chẳng kết thúc như giấc mơ\r\nEm đi qua như dòng chảy của dòng sông\r\nAnh là phiên đá cũ tự hỏi em về không\r\nEm đi qua dòng nước khác vẫn quanh anh\r\nNhưng anh lại cảm thấy nỗi cô đơn vẫn bao quanh\r\nAnh chẳng thể mua được thời gian\r\nChẳng thể yêu ngày hôm qua\r\nCâu chuyện giờ đã lật sang trang\r\nKết chuyện là anh nhìn em rời xa\r\nAnh cứ đi đi tìm tình yêu mới\r\nTôi đứng đây ôm trọn tình yêu cũ\r\nNhắn gió mây gửi đến anh đôi lời\r\nSợi tơ duyên đứt đi rồi có nối lại được không\r\nTừng giây phút\r\nNgày xưa đó\r\nNgười có nhớ\r\nNhớ\r\nNhớ\r\nNhớ không");
            VN.Rows.Add("VN", Properties.Resources.KSD, 0, "Không sao đâu", "cam", "4:54", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN cam - không sao đâu.wav", "CAM:\r\nYeah, hôm nay là ngày thứ mấy ở trong tuần\r\nNhiều cần đã cháy, nhiều lần đã thấy trước được hồi kết nhưng không tuân\r\nMấy lần những cuộc gọi nhỡ và lỡ có buông lời nói mớ, \r\nCũng nhớ gì đâu khi sâu trong óc vẫn còn quá nhiều điều đáng sợ.\r\nMọi thứ dường như đang quá tầm kiểm soát.\r\nCảm giác thế giới qua mặt được em, giờ đã xa tầm liên lạc.\r\nRồi em lại check Facebook, \r\nThâm tâm lại tự trách giây phút em nể bản than mình quá nhiều, \r\nEm để bản than mình hóa liều, quá liều.\r\nĐã bao lâu nay sao em không về nhà ?\r\nCòn phải bao nhiêu đêm trôi qua để mà em thôi rề rà ?\r\nEm nghe lời khuyên và điên từ tối qua,\r\nĐâu phải mê cung nào cũng tìm được lối ra.\r\nEm hay suy tư và dư ra thời giờ,\r\nVà đôi khi em không say no, bao niềm vui ai mời hờ (okay)\r\nChi ra bao nhiêu mua giấc mơ ?\r\nChi ra bao nhiêu ?\r\n\r\nIT’S ALRIGHT,\r\nCòn bao nỗi buồn, mình đâu muốn phải giấu ai.\r\nKhông sao em à, do it, IT’S ALRIGHT.\r\nVừa khóc, vừa cười này. (I wish I cared a little bit more)\r\n\r\nGIMME YOUR SOUL AND THEN GIMME YOUR… X3\r\n\r\nSHYNASTY:\r\nLang thang, lang thang\r\nBiết bao nhiêu ngày tháng, tâm bình thản, chân lang thang.\r\nNhìn những đám mây vàng nhẹ nhàng trôi lãng đãng, nhịp nhàng, đơn giản, ta chỉ muốn được mãn nhãn.\r\nLan man, lan man\r\nĐèn vàng chạng vạng, âm thanh xung quanh vang vang.\r\nKhông gì giới hạn bạn, con tim băng như đang tan.\r\nNhững gì chung tần số, hãy tìm cách để lan sang.\r\nTôi được dạy là không được thử, dù chỉ một lần,\r\nĐặt những thứ thay đổi tâm trạng, chạm gần tới môi.\r\nTôi đã nói không với suy nghĩ này rất nhiều lần,\r\nNhưng khổ nỗi suy nghĩ này lại không nói gì với tôi.\r\nĐôi khi không nguy hiểm như là người ta nghĩ,\r\nChỉ là một chuyến đi, nhưng không mang theo vali.\r\nNhư trôi đi Paris (yeah), như trôi về Bali (yeah).\r\nChỉ là đang giải trí, không cầu kì hay xa xỉ.\r\nCó những lúc ta bị (what), khó tính là đa nghi\r\nCuốn vào sự ma mị, while I’m getting money.\r\nNhững cảm giác lạ kì, nó đến và rồi ra đi.\r\nChỉ đơn giản là vì, đó là hiệu ứng suy nghĩ.\r\n\r\nIT’S ALRIGHT,\r\nCòn bao nỗi buồn, mình đâu muốn phải giấu ai.\r\nKhông sao em à, do it, IT’S ALRIGHT.\r\nVừa khóc, vừa cười này. (I wish I cared a little bit more)\r\n\r\nGIMME YOUR SOUL AND THEN GIMME YOUR… X3");
            VN.Rows.Add("VN", Properties.Resources.SGBQEO, 0, "Sài Gòn buồn quá em ơi", "Dế Choắt", "5:18", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Dế Choắt - Sài Gòn buồn quá em ơi.wav", "Sài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi, em ơi\r\nSài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi\r\nSài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi, em ơi\r\nSài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi\r\n\r\nAnh biết\r\nSài Gòn có những đêm buồn thức trắng\r\nLy cafe sữa vẫn còn vị ngọt nơi đầu môi\r\nAnh biết\r\nLà anh biết tất cả bộn bệ ở nơi mình từng\r\nLàm sao có thể thay đổi\r\nKhi chẳng có người đi cùng đổi thay\r\nTình đầu là tình vụn vỡ\r\nNgày mà mình chưa từng gặp gỡ\r\nNgày hôm qua quá nhiều chuyện buồn\r\nTrong từng nhịp thở\r\nCứ mãi cho đến một ngày\r\nNgày bình thường vô tình gặp nhau\r\nThì mới biết tim đã rối bời\r\nChẳng phải em thì chẳng tìm được đâu\r\nTâm hồn anh thì già cỗi\r\nChưa từng một lần rực rỗi\r\nMỗi khi thấy chân em dừng lại\r\nXin một lần hỏi\r\nNắng chói chang khắp chiều tà\r\nHoàng hôn yên vị xong rồi lại đi\r\nEm là thuyền trưởng\r\nAnh sẽ căng buồm\r\nChẳng ngại vì gió lau nhẹ bờ mi\r\nĐể cho anh một lần được nói\r\nCho anh một lần được hỏi\r\nPhải chăng anh là điểm tựa\r\nĐể em dựa mỗi ngày mệt mỏi?\r\nĐể cho anh một lần được nói\r\nCho anh một lần được hỏi\r\nNếu một ngày không gặp anh nữa\r\nEm có vội vàng đi tìm anh không?\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi lạc thì xem như mất nhau!\r\nNgười vội bước còn người đang đứng sau\r\nCần một điều ước để vượt qua nỗi đau\r\nDù phút chốc Sài Gòn vẫn vui\r\nSao anh mãi buồn?\r\nSài Gòn tháng năm sau\r\nAnh không, không còn em nữa đâu\r\nGiận rồi người cũng xa nhau\r\nQuên nhau, không còn nghĩ đến nhau\r\nNgày buồn nhất là ngày ta vỡ tan\r\nNgười ngồi khóc\r\nCòn người đang trách than\r\nNgày này tháng ấy mình rời bỏ nhau\r\nTrong đêm mưa buồn\r\n\r\nVì tình yêu đã lỡ một nhịp\r\nĐành phải nhường lại cho người đến sau\r\nKhi anh chỉ còn một nhịp\r\nAnh chỉ muốn thở hết những nỗi đau\r\nAnh không tin vào định mệnh\r\nAnh tin vào ngày mai\r\nNếu anh không thể làm được điều gì nữa\r\nThì chắc lẽ là anh sai\r\nVà em nên nhớ\r\nTình yêu không thể\r\nĐếm bằng ngày đâu em\r\nĐó là tất cả những gì đọng lại\r\nSau nhưng đêm dài buồn không tên\r\nĐến khi cảm xúc thấu được mình đã\r\nTrải qua quá nhiều lần tổn thương\r\nChiếc gương ấy sẽ xóa được hình bóng ai\r\nĐã khiến lòng mình vấn vương\r\nDù sai, dù đúng\r\nTất cả cũng không quan trọng vì\r\nNgười đi, người đến người ở lại\r\nLà vì hiểu nhau thì\r\nNgày em buồn nhất\r\nAnh sẽ đứng lại dù trời có mưa\r\nVà anh muốn hỏi tất cả chuyện buồn\r\nEm đã cất chưa\r\nBình yên là lúc ta cùng nhìn lại\r\nNở một nụ cười cho dù đớn đau\r\nBình yên là lúc có người tồn tại\r\nLuôn nằm phía sau\r\nTình yêu đẹp nhất khi lòng thù hận\r\nEm cần vứt đi\r\nTình yêu chỉ đến sau những mảnh vụn\r\nCó kẻ ghép lại, lau nhẹ ướt mi\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi lạc thì xem như mất nhau!\r\nNgười vội bước còn người đang đứng sau\r\nCần một điều ước để vượt qua nỗi đau\r\nDù phút chốc Sài Gòn vẫn vui\r\nSao anh mãi buồn?\r\nSài Gòn tháng năm sau\r\nAnh không, không còn em nữa đâu\r\nGiận rồi người cũng xa nhau\r\nQuên nhau, không còn nghĩ đến nhau\r\nNgày buồn nhất là ngày ta vỡ tan\r\nNgười ngồi khóc\r\nCòn người đang trách than\r\nNgày này tháng ấy mình rời bỏ nhau\r\nTrong đêm mưa buồn\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi, lạc thì xem như mất nhau!\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi, lạc thì xem như mất nhau!");
            VN.Rows.Add("VN", Properties.Resources.TT, 0, "Trốn Tìm", "Đen", "4:12", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Đen - Trốn Tìm.wav", "Có một cái cây trong một cái vườn\r\nTrên những tán cây nở rộ những đoá hoa\r\nCó hai đứa nhóc đang chơi trốn tìm\r\nTìm hoài tìm mãi nên quên lối về\r\nAnh đi tìm thì em trốn anh đi trốn em không tìm\r\nLòng em không gợn sóng cuối cùng anh mất công chìm\r\nNếu mà có cây búa anh sẽ nện cho bõ công\r\nVì nhớ nhung đặc quánh giờ nó khô thành bê tông\r\nChúng ta rồi sẽ có có những chuyến đi dài\r\nTa tự học lấy mọi thứ vì trong tình trường làm biếng ghi bài\r\nCâu chuyện của chúng ta bỗng có thêm một miếng bi hài\r\nVì cách mà em gọi anh không có u và thiếu y dài\r\nPhía xa thành phố người ta đã bật đèn đường\r\nHương quen xưa làm anh thấy thật thèm thuồng\r\nNỗi buồn vàng rực cứ như là chứa đồng thau\r\nHệt như là Beckham vậy em chỉ giỏi cứa lòng nhau\r\nHé cửa sổ ra mà xem\r\nCó một chàng thi sĩ đứng ở ngay nhà em\r\nViết nhạc tình mát ngọt tựa như cây cà rem\r\nAnh ta sẽ đứng ở nơi đây cả đêm\r\nCó hai cái cây trong một cái vườn (có hai cái cây trong vườn)\r\nTrên những tán cây nở rộ những đoá hoa (có những đoá hoa trên cành)\r\nCó hai đứa nhóc đang chơi trốn tìm (có hai đứa nhóc đang chơi)\r\nTìm hoài tìm mãi nên quên lối về\r\nHồi đó anh rụt rè như đám cây mắc cỡ\r\nGần em làm anh hồi hộp tới mức gây tắc thở\r\nTa đều không biết có điều gì sau đám mây sắp nở\r\nTrò chơi trốn tìm ngày đó sau này đầy trắc trở\r\nTa săn bắn những khát vọng và hái lượm những giấc mơ\r\nTa gieo trồng cây ước mộng thứ mà lấy đi nhiều thì giờ\r\nTa đào những cái hố mà không biết có ngày bị lọt\r\nĐể rất lâu sau này chúng ta cau mày nhận ra không phải tất cả bông hoa thì đều sẽ có những nhụy ngọt\r\nGọi tên em làm anh mất giọng hoài\r\nHệt như là một giấc mộng dài\r\nTa đi tìm cả thế giới nhưng mà lại trốn nhau\r\nBiết vậy thà nghỉ chơi từ lúc mới chớm đau (từ lúc mới chớm đau)\r\nNgười đi tìm cái người đi trốn\r\nNgười đi trốn cái người đi tìm\r\nTình yêu từ những ngày xưa đã\r\nNgủ quên dưới tán cây im lìm\r\nCó ba cái cây trong một cái cái vườn\r\nTrên những tán cây nở rộ những đoá hoa\r\nCó hai đứa nhóc đang chơi trốn tìm\r\nTìm hoài tìm mãi nên quên lối về\r\nAi đó đã chặt hết cây và cũng chẳng thấy vườn (chẳng thấy cây trong vườn)\r\nAi đó đã xây một ngôi nhà rất to (chặt hết cây đi rồi)\r\nChắc em hạnh phúc yên vui với người (chắc em hạnh phúc yên vui)\r\nNhà em có chó anh không dám vào\r\nNiềm cô đơn của những người trưởng thành\r\nLà khi muốn trốn nhưng không ai tìm\r\nNhiều khi ta muốn ta được bé lại\r\nĐể khi đi trốn có người đi tìm\r\nNhiều khi ta muốn ta được bé lại\r\nĐể khi đi trốn có người đi tìm");
            VN.Rows.Add("VN", Properties.Resources.LYS, 0, "Loving You Sunny", "Kimmese", "4:56", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Kimmese - Loving You Sunny.wav", "Thoát ra mối sầu đêm nay\r\nCho em gối đầu lên tay\r\nKhông cần thuê người tư vấn\r\nYên tâm mình sẽ tự phối màu thêm hay\r\nAnh sẽ pha màu nhạt khói\r\nVào màu trầm của môi em\r\nVà nếu bên nhau là lạc lối\r\nThì mình cứ để mọi thứ kia trôi êm\r\nI wish you could give me another chance\r\nHave you ever thought of us as a future plan\r\nInside my heart, I know I don't wanna give up\r\nUntil i can have your love\r\nI know it worths it baby\r\nI know what makes me happy is you\r\nNobody could\r\nKiss me like the way you do\r\nThe way you talk to me, yeah\r\nI don't need no drugs only your love make me feel that high\r\nSunny that's why I love you\r\nOnly you can make me feel, in love again\r\nPicture me in the battle, finding you again\r\nI can feel a sunshine, in me one more time\r\nWhenever I see yo green eyes\r\nThats why I love you sunny\r\nHere's my heart just take it everywhere you go\r\nDestiny will bring me back to you for show\r\nWoah, I know you got everything i want\r\nIf you still love me\r\nGive me a chance\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h-oh-oh, Sunny\r\nYou\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h oh-oh, Sunny\r\nYou\r\nYou're amazing you're unique\r\nAnd you're bad\r\nYour lifestyle, interesting, passionate\r\nAnd I adore you\r\nBy the way you carry yourself\r\nBabe, you do it so well\r\nAnd I like that, like that\r\nI wanna show you my real world\r\nNo acting up, no playing games\r\nNo wall\r\nJust spend with me and u will see\r\nWe are meant to be\r\nCause i'm your baby\r\nOnly you can make me feel in love again\r\nPicture me in the battle, finding you again\r\nI can feel a sunshine in me one more time\r\nWhenever I see yo green eyes\r\nThats why I love you sunny\r\nHere's my heart just take it everywhere you go\r\nDestiny will bring me back to you for show\r\nWoah, I know you got everything i want\r\nIf you still love me\r\nGive me a chance\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h-oh-oh, Sunny\r\nYou\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h oh-oh, Sunny\r\nYou\r\nEm không cần mặc đẹp, vì anh thích lôi thôi\r\nGiam em bằng vòng tay rộng và\r\nTra tấn em bằng đôi môi\r\nLòng mình vui như tết á\r\nKhông cần chờ đêm ba mươi\r\nThả mình vào trong biển lớn\r\nKhông cần buồm mà ra khơi\r\nVì mình có quá nhiều ngày cô đơn nên ngày bên em dường như là không đủ\r\nMình sẽ phải cần thêm nhiều cà phê hơn\r\nVì đêm nay chúng ta sẽ không ngủ\r\nAnh sẽ vặn ngược lại kim của đồng hồ\r\nĐể nó luôn chỉ thời khắc nửa đêm\r\nTa sẽ có một ngày dài như là thế kỷ như vậy mới đủ để cho anh hiểu em\r\nNói lời chân thật với nhau, đừng bắt tâm tư phải sàng và lọc\r\nEm cần may túi ba gang vì lúc bên nhau là vàng là ngọc\r\nCó hàng tá rapper ngoài kia nhưng sẽ không có một Đen thứ hai\r\nViết cho em những điều kì lạ, em sẽ nhận ra chỉ Đen chứ ai\r\nBởi vì anh không thích đồ ngọt nên hãy yêu nhau theo cách mặn mà\r\nCứ yên tâm nhạc tình Đen viết luôn đặc quánh và rất đậm đà\r\nChắt chiu như trong một sớm trên lá đọng vệt trong ngần sương\r\nYêu em như cách anh viết nhạc, luôn cần mẫn mà không cần lương\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h-oh-oh, Sunny\r\nYou\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h oh-oh, Sunny\r\nYou");
            VN.Rows.Add("VN", Properties.Resources.CCTX, 0, "Chuyện chàng trông xe", "MCK", "3:15", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN MCK - Chuyện chàng trông xe.wav", "một toán học sinh lại đến\r\ncầm phấn viết lên yên xe\r\n24 25 biết khi nào xong\r\n“Xe em cho thẳng vào trong nhé”\r\nVina còn chưa kịp châm\r\ntrà đá vẫn chưa kịp nhấp môi\r\nTrời sập tối mưa rào\r\n\r\ndòng xe chắp nối đưa vào\r\n\r\nvà em \r\nsố xe 07 em ra mà xem\r\n\r\nlàm anh nhớ mong cả đêm\r\n\r\nthế nhưng cái tên lại quên\r\nvà anh\r\nlàm nghề cầm phấn nhưng không ai nghe\r\nBa anh lái xe bảo học không nghe\r\nthế nên giờ đây số kiếp trông xe\r\nđừng làm anh mong nhớ\r\nsánh đôi có lẽ chỉ ở trong mơ thôi\r\nchạm mặt em xong lỡ\r\ntrái Tim vụn vỡ lại đập loạn nhịp mong chờ\r\n\r\nsinh ra ở khu lao động không đi trông xe thì cũng xách vữa\r\nphổ biến là làm lao công còn muốn nghèo có thêm chục cách nữa\r\nBố mẹ anh không đủ tiền cho anh đi học cùng bạn trang lứa\r\nCây phấn mỗi ngày anh dùng phủ cuộc đời anh trắng thêm trang nữa\r\nđồng phục, tóc búi, cười hiền đi converse và em sơ vin\r\nlướt qua là anh muốn cưới, lấy giấy tờ, bỏ vào all in ô in\r\nEm như cây bút chì màu vẽ cuộc đời anh ở khung hình riêng\r\nThơ ngay 1 chút tình đầu anh muốn xoá bỏ đi những định kiến\r\nbố mẹ vẫn bảo anh là “sao mày đũa mốc mà chòi mâm son”\r\nhọc toán còn chưa ăn ai bây h mày thích học đòi không con\r\nmuốn đưa vé xe cho em nhưng anh lại sợ làm dơ áo trắng\r\nGiọng em ngọt như kem làm cổ họng anh tự nhiên nó đắng\r\n\r\ntương tư về em mỗi đêm cùng với thăng long anh lười không ngủ\r\ntưởng như chỉ yêu mỗi em dưới ánh trăng cong chửi “người âm phủ”\r\nmấy thằng con trai miệng lưỡi dẻo quẹo thì xin em đừng cả tin\r\nngoài đời thì nó thả bả còn lên mạng thì nó thả tim\r\n1 túp lều tranh 2 trái Tim vàng thì chắc bây giờ không có\r\nNgày 2 chúng ta yêu nhau thì chắc là ngày mặt trời không ló\r\nbố mẹ em cần ví dày nhưng giống bụng anh ví anh lép kẹp\r\nnhà anh có mỗi cửa sổ nên chuyện tình mình giờ chắc khép đẹp");
            VN.Rows.Add("VN", Properties.Resources.AKTGDAL, 0, "Anh không thề gì đâu anh làm", "Phúc Du", "2:10", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN PHÚC DU - ANH KHÔNG THỀ GÌ ĐÂU ANH LÀM.wav", "Ngày tháng có em bên cạnh trôi qua như một cơn mơ nhanh\r\nAnh có phải là bắp rang đâu mà em bơ anh\r\nEm ơi, xin đừng giận anh, đừng làm khó thêm\r\nTrong tim anh em như là Hawkeye, vì em luôn có tên\r\nEm luôn đứng đầu, em luôn đứng đầu\r\nDù em như bị trúng gió, em cứng cổ và cứng đầu\r\nAnh yêu em và nhiều đêm, tương tư anh lại nhiều thêm\r\nNgười ta thích là chiều ta, còn anh thì chỉ thích chiều em\r\nBên cạnh em anh luôn là khó ngầu\r\nVì nếu tim anh là mùa xuân, em là cơn gió đầu\r\nNghĩ về em cả hàng giờ, anh không mong tim em có sầu\r\nYêu em như một bàn cờ, anh mong kết cục có hậu\r\nTa cạn say, chén rượu xuân cay nồng và ngắm cánh nhạn bay\r\nChuyện tình ta như Iphone, mở ra từ cái chạm tay\r\nAnh không muốn thấy đạn bay và tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không muốn thấy đạn bay, tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm\r\nAnh nói thật là anh ghét nhất những lần ta cãi vã\r\nKhông phải chuyển giới nhưng đôi lúc anh thấy em thái quá\r\nĐâu là lí do đấy là thứ anh còn tìm\r\nNhiều lúc không biết anh đang yêu em hay anh đang chơi dò mìn\r\nNgày mà em giận, anh thấy u ám như ngày mưa\r\nSợ tình ta sẽ phải úa tàn như là vườn hồng ngày xưa\r\nĐến với em anh ôm hi vọng còn mưu mẹo thì quên đem\r\nĐếch cần 36 kế, anh chỉ cần kế bên em\r\nThương em từ sáng tới lúc trời tối đen thui\r\nHọ gọi anh là MC nhưng anh chỉ muốn làm em vui\r\nNên dù em đã nhận lời yêu anh vẫn còn thèm cưa em\r\nEm không đẹp như siêu mẫu mà siêu mẫu họ đẹp như em\r\nTừ ngày hẹn hò em làm anh thêm thói quen\r\nGiờ anh thích ăn kem vì trong kem có em\r\nEm cứ yên tâm, anh sẽ không để tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không muốn thấy đạn bay, tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm");
            VN.Rows.Add("VN", Properties.Resources.TLC, 0, "Trên Lầu Cao", "Rhymastics", "3:56", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Rhymastic - Trên Lầu Cao.wav", "Money flows in, money flows out\r\nBeware of the fishin' round it\r\nTao đi đường riêng\r\nCho dù còn bao nhiêu là ánh mắt vẫn đang liếc đi theo rình\r\n(Haters thì sao?)\r\nHaters thì sao?\r\nHỏi thằng nào mà không biết tên tao?\r\nTao mải là tao nên chưa kịp tiếp thằng nào\r\nMuốn được biết thì xuống tít bên dưới xếp hàng mau (Lineup)\r\nLife's the peephole (Yeah)\r\nYou see what your mind wanna believe though (No lie)\r\nNên tao đâu cần đi đầu (Nope)\r\nCứ đi theo lời mách bảo trong lí trí tao (That's right)\r\nYeah, cũng có lúc tao lạc mất tiết tấu\r\nYeah, cũng có lúc nhịp tao lơi\r\nVẫn lean on xuống deep low\r\nĐể nhịp swing bám vào beat và lời\r\n(Nhịp swing bám vào beat và lời)\r\n(Nhịp swing bám vào beat và lời)\r\nYeah\r\nVà khi sang ngày mới những vương bận chỉ còn là nốt nhạc cũ rích mà thôi (move up)\r\nĐạp mạnh chân ga cho bô nhả khói\r\nĐâu ai đi lạc lối cả đời?\r\nTầm nhìn mày liệu có vươn xa tới?\r\nHay là trên lời nói đầu môi?\r\nVạn vật đổi dời\r\nTao đâu dừng chân chờ ngày tàn kia đuổi tới\r\nTao đâu ngồi than khi thời gian đang tuột trôi\r\nBao nhiêu ngổn ngang đâu cần mang theo cuộc chơi?\r\nCàng nhiều buộc trói\r\nMày có thở nổi khi càng ngày càng lên cao?\r\nKhông gian càng loãng những cám dỗ càng biến ảo\r\nVà nếu mày không biết tao\r\nChắc mày nghĩ đây chỉ là câu chuyện hão (Yeah)\r\nNhạc high as em nghe theo bao nhiêu lâu? (Low)\r\nUnderground nhưng phát ở trên tầng lầu (low)\r\nSo high I paralyzed from down below (low)\r\nUnderground getting down with top flo' (low)\r\nLà underground trên lầu cao\r\n(It's how we roll around here)\r\nUnderground trên lầu cao\r\n(It's high level now)\r\nUnderground trên lầu cao\r\n(It's how we roll around here)\r\nLà underground trên lầu cao\r\nĐời ngắn có lúc đắng có lúc say\r\nChỉ sợ là mình lắm lúc mất trắng những phút giây\r\nNhiều người chìm đắm bao nhiêu năm vẫn cứ vậy\r\nThì liệu mày còn buồm căng qua vũng lầy?\r\nHay là mày thích nghe kể khổ?\r\nThích nghe kể nghèo?\r\nThích an ủi mình chùn tay?\r\nĐể rồi rả rích điệp khúc cũ\r\n\"Vì đời lắt léo thì mới chọn đường cùng này\"\r\nĐâu cần vạch đích để biết mình đang chạy\r\nCần gì thành tích để khích mình hăng say\r\nĐời người thành bại đều do mình giằng lấy\r\nKẻ vươn xa người đứng lại đều nằm ở tầm tay\r\nVì ngày mai biết được ai sẽ bị thay mới\r\nDại gì phí hoài để tương lai trôi\r\nKiếp này được vươn vai để mày trải đời\r\nLiệu mày có lại ngồi dưới đáy than đời phai phôi?\r\nVì sẽ có kẻ chỉ nói mà không làm\r\nNgười càng đói lại càng thích phàn nàn\r\nThành công vang dội thì cần gì lan man\r\nKhi chẳng cần nhiều lời miệng đời vẫn bàn tán\r\nDù lòng mày còn vướng bận, nghiệp mày còn gian nan\r\nThì cứ lấy danh dự làm la bàn\r\nChỉ cần nhớ được rằng, đêm tối dù hoạn nạn\r\nĐừng quay lưng khi mày tỏa sáng\r\nNên sân khấu này bật xuyên đêm\r\nNơi tao đứng Spaceboys luôn thức\r\nTúc trực cho những người anh em\r\nMượn lời bằng nhạc dắt nhau tới tận cùng\r\nAi cũng có thể được mời đến\r\nNhưng bản lĩnh mới được ngồi bàn trong\r\nVì tiền ở đây tha hồ đếm, khi có trình độ đúc từ vàng ròng\r\nNhạc high as em nghe theo bao nhiêu lâu? (Bao nhiêu lâu?)\r\nUnderground nhưng phát ở trên tầng lầu (Trên tầng lầu)\r\nSo high I paralyzed from down below (Chears to all my brothers and sisters)\r\nUnderground getting down with top flo'\r\nGet down!\r\nUnderground trên lầu cao\r\n(It's how we roll around here)\r\nUnderground trên lầu cao\r\n(It's high level now)\r\nUnderground trên lầu cao\r\n(It's how we roll around here)\r\nLà underground trên lầu cao");
            VN.Rows.Add("VN", Properties.Resources.NGTT, 0, "Nhập gia tùy tục", "Sol7", "3:56", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Sol7 - Nhập Gia Tuỳ Tục.wav", "You know me\r\nYou know me, yeah\r\nNgồi lên ngựa sắt\r\nLái qua phố riêng mình ta\r\nTrên chiến trường\r\nNhưng đang hát tình ca\r\nNgười đánh giá ta\r\nQua vài tấm hình mà\r\nÔng bà đã nói\r\nPhải biết trông rộng nhìn xa\r\nLập chiến tích không gây chiến tranh\r\nHoàn thành rồi anh em mình biến nhanh\r\nNhập gia thì tùy tục\r\nAnh hiền, ừ cũng tùy lúc\r\nMái đầu 7/3 cầm cây guitar rồi gảy ra\r\nĐứng yên như cột cờ nhưng ai ai cũng thấy ta\r\nKhông phải vận động viên nhưng mùa này anh nhảy xa\r\nÁp lực nặng như đá, ta là nước cứ chảy qua\r\nSăn tiền thưởng như cao bồi, uh\r\nAnh em đều có phần đam mê được trau dồi\r\nChẳng cần bước lên cao ngồi\r\nNói anh thất bại giờ mấy đứa nó sao rồi\r\nOn top ở trên tuần báo\r\nLấy tên tuổi cho thằng em bán quần áo\r\nLàm cho cả băng DCOD giá trị gia tăng\r\nỞ trong khu có người tự hào, thằng đó là bạn mình\r\nCòn nụ cười khinh thì anh coi như nó đang tàng hình\r\nFly Team, bay một đàn như loài chim\r\nĐể lại dấu ấn trên da như ngòi kim\r\nTừ đời thiệt ra lời viết\r\nHiên ngang giữa mọi thời tiết\r\nDòng đời và âm nhạc\r\nMuốn anh phải liều lĩnh\r\nThời gian là tiền bạc anh cần phải điều chỉnh\r\nNgồi lên ngựa sắt\r\nLái qua phố riêng mình ta\r\nTrên chiến trường\r\nNhưng đang hát tình ca\r\nNgười đánh giá ta\r\nQua vài tấm hình mà\r\nÔng bà đã nói\r\nPhải biết trông rộng nhìn xa\r\nMình tiến lên trong cuộc chơi mọi thứ an bài\r\nTui làm nhạc ông mê đá banh anh em ngang tài\r\nMàu cờ anh đưa lên thang dài\r\nĐón em anh đem vào trang đài\r\nBuổi sáng đang soi mái đầu anh chải\r\nChiều em mặc đồ bơi bên biển xanh mãi\r\nTối đi nghe nhạc để sầu nhanh giải\r\nBỏ ngoài tai trên mạng còn nhiều tranh cãi\r\nVẫn chờ người về đây ta cùng bay đến tương lai\r\nSợ gì vài cây, ngựa hay phải chạy đường dài\r\nNhư Cowboy viễn Tây đôi tay nhanh hơn chướng ngại\r\nKhông cần sắt đá ta vẫn xây nên tượng đài\r\nYou know I'm keeping my weapon like a soldier\r\nGiữa chặng đường dừng lại hét lên thử thách anh đâu sợ\r\nChẳng hề độc bước gia đình anh em ở sau chờ\r\nMỗi lần buồn phiền hãy ngước lên gọi Hallelujah\r\nTrôi dạt mênh mông như mây ở trên không\r\nGiọng anh trầm, yeah anh không cần lên tone\r\nGiọng anh trầm, yeah anh không cần lên tone\r\nAnh không cần lên tone\r\nNgồi lên ngựa sắt\r\nLái qua phố riêng mình ta\r\nTrên chiến trường\r\nNhưng đang hát tình ca\r\nNgười đánh giá ta\r\nQua vài tấm hình mà\r\nÔng bà đã nói\r\nPhải biết trông rộng nhìn xa\r\nNhẹ chạm bờ môi em mượt mà như câu thở\r\nGần nhau thật lâu làm màu son lại mau mờ\r\nThả thêm vài câu em nói anh câu giờ\r\nTừ lời, từng flow người anh thi người cover\r\nAnh rap khi có phiêu, keep it real\r\nĐiều chưa có không dám nêu, không nói điêu\r\nAnh đã thiêu những quá khứ, anh có tàn tro đen\r\nTừ bùn lầy anh ngoi lên chẳng khác gì hoa sen, graaa!");
            VN.Rows.Add("VN", Properties.Resources.BT, 0, "Blue Tequila", "Táo", "4:21", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Táo - Blue Tequila.wav", "Hai tequila như mọi khi trong tuần\r\nNhạc bật Frank Sinatra nhưng mà tôi không cần\r\nBuồn phiền từ đâu lao đến đây vây quanh\r\nMệt nhoài cùng tôi đang nắm tay\r\nEm ra ban công vô tình đi ngang quầy\r\nHình như em đang say sau vài ly vang đầy\r\nTình cờ đời ta va lấy nhau, không may\r\nNgười tìm được tôi nơi đáy sâu\r\n\r\nBồi hồi nhìn nhau điếu thuốc kia đang tàn\r\nNgoài đường dòng xe nối tiếp nhau vội vàng\r\nNhiều lần hợp tan nuối tiếc trong muộn màng\r\nChỉ cần một ai xoá hết đi thời gian\r\nĐừng làm trời lên khói thuốc kia thay màu\r\nĐừng làm bầu không khí chuốc thêm ưu sầu\r\nĐừng làm tình ta sẽ chết ngay ban đầu\r\nDù mập mờ không biết sẽ đi về đâu.\r\n\r\nVà người nhìn bằng đôi mắt khép hờ lại bờ môi\r\nMột người làm lòng tôi muốn có một người cần tôi\r\nSau bao dối gian trong đời\r\nYêu đương hoá ra không lời, nên...\r\nNgười chìm mình vào ao ước biến cuộc tình thành phim\r\nNgười vì vài lần đau đớn bắt lòng mình lặng im\r\nRiêng tôi sẽ luôn yêu người\r\nNhư tôi đã luôn yêu người\r\nTừ đầu.\r\n\r\nEm thở nhẹ một sợi khói, khiến bầu trời vỡ làm hai nửa\r\nNếu mà anh không tới, thì cả đời đâu còn ai sửa\r\nĐóm lửa đỏ trên đầu thuốc rơi vào gạt tàn như thể sao băng\r\nHồn anh như lạc đàn ở giữa bạt ngàn góc rễ bao quanh\r\nXin lỗi vì lòng hơi say, trong đầu thì đầy chếnh choáng\r\nCảm ơn những nỗi buồn vì đã đưa đôi chân này đến quán\r\nAnh biết là nếu đêm tàn sẽ kéo thêm ngàn suy nghĩ miên man\r\nNên là, vui đi, để tim mình liên hoang\r\n\r\nNgười khép đôi hàng mi không sầu vương đang nhìn tôi\r\nNgười khiến tôi nhận ra tôi chỉ yêu em mà thôi\r\nSau bao dối gian trong đời\r\nYêu đương hoá ra không lời nên\r\nCòn có bao người mong cho tình yêu kia thành phim\r\nVà có bao người đau nên buộc con tim lặng im\r\nRiêng tôi sẽ luôn yêu người\r\nNhư tôi đã luôn yêu người\r\nTừ đầu...");
        }
        private void ENLoad()
        {
            EN.Columns.Add("theloai", typeof(string));
            EN.Columns.Add("hinhanh", typeof(object));
            EN.Columns.Add("liked", typeof(string));
            EN.Columns.Add("tenbaihat", typeof(string));
            EN.Columns.Add("tencasi", typeof(string));
            EN.Columns.Add("thoiluong", typeof(string));
            EN.Columns.Add("binhluan", typeof(string));
            EN.Columns.Add("baihat", typeof(string));
            EN.Columns.Add("loibaihat", typeof(string));
            // the loai - hinh anh -ten bai hat - ten ca si - thoi luong - bai hat - lyric

            EN.Rows.Add("EN", Properties.Resources.The_Lazy_Song, 0, "The Lazy Song", "Bruno Mars", "3:28", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Bruno Mars - The Lazy Song.wav", "Today I don't feel like doing anything\r\nI just wanna lay in my bed\r\nDon't feel like picking up my phone\r\nSo leave a message at the tone\r\n'Cause today I swear I'm not doing anything\r\nUh, I'm gonna kick my feet up then stare at the fan\r\nTurn the TV on, throw my hand in my pants\r\nNobody's gon' tell me I can't, nah\r\nI'll be lounging on the couch, just chilling in my Snuggie\r\nClick to MTV so they can teach me how to dougie\r\n'Cause in my castle I'm the freaking man\r\nOh, yes, I said it, I said it, I said it 'cause I can\r\nToday I don't feel like doing anything\r\nI just wanna lay in my bed\r\nDon't feel like picking up my phone\r\nSo leave a message at the tone\r\n'Cause today I swear I'm not doing anything\r\nNothing at all\r\nWoo-ooh, woo-ooh, ooh\r\nNothing at all\r\nWoo-ooh, woo-ooh, ooh\r\nTomorrow I'll wake up, do some P90X\r\nMeet a really nice girl, have some really nice sex\r\nAnd she's gonna scream out, \"This is great\" (oh, my God, this is great), yeah\r\nI might mess around and get my college degree\r\nI bet my old man will be so proud of me\r\nBut sorry pops, you'll just have to wait\r\nOh, yes, I said it, I said it, I said it 'cause I can\r\nToday I don't feel like doing anything\r\nI just wanna lay in my bed\r\nDon't feel like picking up my phone\r\nSo leave a message at the tone\r\n'Cause today I swear I'm not doing anything\r\nNo, I ain't gonna comb my hair\r\n'Cause I ain't going anywhere\r\nNo, no, no, no, no, no, no, no, no, oh\r\nI'll just strut in my birthday suit\r\nAnd let everything hang loose\r\nYeah, yeah, yeah, yeah, yeah, yeah, yeah, yeah, yeah, yeah\r\nOh, today I don't feel like doing anything\r\nI just wanna lay in my bed\r\nDon't feel like picking up my phone\r\nSo leave a message at the tone\r\n'Cause today I swear I'm not doing anything\r\nNothing at all\r\nWoo-ooh, woo-ooh, ooh\r\nNothing at all\r\nWoo-ooh, woo-ooh, ooh\r\nNothing at all");
            EN.Rows.Add("EN", Properties.Resources.Heat_Waves, 0, "Heat Waves", "Glass Animals", "3:55", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Glass Animals - Heat Waves.wav", "Road shimmer\r\nWiggling the vision\r\nHeat heat waves\r\nI'm swimming in a mirror\r\nRoad shimmer\r\nWiggling the vision\r\nHeat heat waves\r\nI'm swimming in a\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nUsually I put\r\nSomething on TV\r\nSo we never think\r\nAbout you and me\r\nBut today I see\r\nOur reflections\r\nClearly in Hollywood\r\nLaying on the screen\r\nYou just need a better life than this\r\nYou need something I can never give\r\nFake water all across the road\r\nIt's gone now, the night has come, but\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nYou can't fight it\r\nYou can't breathe\r\nYou say something so loving, but\r\nNow I've got to let you go\r\nYou'll be better off in someone new\r\nI don't wanna be alone\r\nYou know it hurts me too\r\nYou look so broken when you cry\r\nOne more and then I'll say goodbye\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nI just wonder what you're dreaming of\r\nWhen you sleep and smile so comfortable\r\nI just wish that I could give you that\r\nThat look that's perfectly un-sad\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nHeat waves been faking me out\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nRoad shimmer\r\nWiggling the vision\r\nHeat heat waves\r\nI'm swimming in a mirror\r\nRoad shimmer\r\nWiggling the vision\r\nHeat heat waves\r\nI'm swimming in a mirror");
            EN.Rows.Add("EN", Properties.Resources.Head_In_The_Cloud, 0, "Head In The Cloud", "Hayd", "3:07", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Hayd - Head In The Clouds.wav", "I miss the days when life was so simple\r\nFelt like the glass was always half full\r\nWhere did that go?\r\nAnd every second with you was so special\r\nBack when we didn't fear the unknowns\r\nBut that was long ago\r\nWho can say where the path will go?\r\nPhilosophers guess but they just don't know\r\nMaybe that's why\r\nWe had our head in the clouds\r\nThought we had it all figured out\r\nPlanning to fly away\r\nTo escape everything on the ground\r\nBut like a plane up in space\r\nWe slowly drifted away\r\nAnd every plan that we made\r\nAnd dream that we chased\r\nAre just memories now\r\nThey're just memories now\r\nI'm not sure where everything went wrong\r\nBut I know that we landed where we both belong\r\n(Where we both belong)\r\nI just wish we weren't scared to say\r\nThat there's expiration dates on the friends you make\r\nAs hard as that may sound\r\nWho can say where the path will go?\r\nPhilosophers guess but they just don't know\r\nMaybe that's why\r\nWe had our head in the clouds\r\nThought we had it all figured out\r\nPlanning to fly away\r\nTo escape everything on the ground\r\nBut like a plane up in space\r\nWe slowly drifted away\r\nAnd every plan that we made\r\nAnd dream that we chased\r\nAre just memories now\r\nThey're just memories now\r\nWho can say where the path will go?\r\n(Where the path will go? Where the path will go?)\r\nPhilosophers guess but they just don't know\r\n(But they just don't know)\r\n");
            EN.Rows.Add("EN", Properties.Resources.Comethru, 0, "comethru", "Jeremy Zucker", "3:00", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Jeremy Zucker - comethru.wav", "I might lose my mind\r\nWaking when the sun's down\r\nRiding all these highs\r\nWaiting for the comedown\r\nWalk these streets with me\r\nI'm doing decently\r\nJust glad that I can breathe, yeah\r\nI'm trying to realize\r\nIt's alright to not be fine on your own\r\nNow I'm shaking, drinking all this coffee\r\nThese last few weeks have been exhausting\r\nI'm lost in my imagination\r\nAnd there's one thing that I need from you\r\nCan you come through, through?\r\nThrough, yeah\r\nAnd there's one thing that I need from you\r\nCan you come through?\r\nAin't got much to do\r\nToo old for my hometown\r\nWent to bed at noon\r\nCouldn't put my phone down\r\nScrolling patiently\r\nIt's all the same to me\r\nJust faces on a screen, yeah\r\nI'm trying to realize\r\nIt's alright to not be fine on your own\r\nNow I'm shaking, drinking all this coffee\r\nThese last few weeks have been exhausting\r\nI'm lost in my imagination\r\nAnd there's one thing that I need from you\r\nCan you come through, through?\r\nThrough, yeah\r\nAnd there's one thing that I need from you\r\nCan you come\r\nThrough, through\r\nThrough, yeah\r\nAnd there's one thing that I need from you\r\nCan you come through?");
            EN.Rows.Add("EN", Properties.Resources.Paris_In_The_Rain, 0, "Paris in the Rain", "Lauv", "3:36", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Lauv - Paris in the Rain.wav", "All I know is (ooh ooh ooh)\r\nWe could go anywhere, we could do\r\nAnything, girl, whatever the mood we're in\r\nYeah all I know is (ooh ooh ooh)\r\nGetting lost late at night, under stars\r\nFinding love standing right where we are, your lips\r\nThey pull me in the moment\r\nYou and I alone and\r\nPeople may be watching, I don't mind\r\n'Cause anywhere with you feels right\r\nAnywhere with you feels like\r\nParis in the rain\r\nParis in the rain\r\nWe don't need a fancy town\r\nOr bottles that we can't pronounce\r\n'Cause anywhere, babe\r\nIs like Paris in the rain\r\nWhen I'm with you ooh ooh ooh\r\nWhen I'm with you ooh ooh ooh\r\nParis in the rain\r\nParis in the rain\r\nI look at you now and I want this forever\r\nI might not deserve it but there's nothing better\r\nDon't know how I ever did it all without you\r\nMy heart is about to, about to jump out of my chest\r\nFeelings they come and they go, that they do\r\nFeelings they come and they go, not with you\r\nThe late nights\r\nAnd the street lights\r\nAnd the people\r\nLook at me girl\r\nAnd the whole world could stop\r\nAnywhere with you feels right\r\nAnywhere with you feels like\r\nParis in the rain\r\nParis in the rain\r\nWe don't need a fancy town\r\nOr bottles that we can't pronounce\r\n'Cause anywhere, babe\r\nIs like Paris in the rain\r\nWhen I'm with you ooh ooh\r\nWhen I'm with you ooh ooh\r\nParis in the rain\r\nParis in the rain\r\nOh\r\nGirl, when I'm not with you\r\nAll I do is miss you\r\nSo come and set the mood right\r\nUnderneath the moonlight\r\n(Days in Paris\r\nNights in Paris)\r\nPaint you with my eyes closed\r\nWonder where the time goes\r\n(Yeah, isn't it obvious?\r\nIsn't it obvious?)\r\nSo come and set the mood right\r\nUnderneath the moonlight\r\n'Cause anywhere with you feels right\r\nAnywhere with you feels like\r\nParis in the rain\r\nParis in the rain\r\nWalking down an empty street\r\nPuddles underneath our feet");
            EN.Rows.Add("EN", Properties.Resources.Rude, 0, "Rude", "MAGIC!", "3:45", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG MAGIC - Rude.wav", "Saturday mornin', jumped out of bed\r\nAnd put on my best suit\r\nGot in my car and raced like a jet\r\nAll the way to you\r\nKnocked on your door with heart in my hand\r\nTo ask you a question\r\n'Cause I know that you're an old fashioned man\r\nYeah (yeah)\r\nCan I have your daughter for the rest of my life?\r\nSay yes, say yes, 'cause I need to know\r\nYou say I'll never get your blessin' 'til the day I die\r\n\"Tough luck, my friend, but the answer is no\"\r\nWhy you gotta be so rude?\r\nDon't you know I'm human too?\r\nWhy you gotta be so rude?\r\nI'm gonna marry her anyway\r\n(Marry that girl) marry her anyway\r\n(Marry that girl) yeah, no matter what you say\r\n(Marry that girl) and we'll be a family\r\nWhy you gotta be so rude?\r\nI hate to do this, you leave no choice\r\nCan't live without her\r\nLove me or hate me, we will be both\r\nStandin' at that alter\r\nOr we will run away\r\nTo another galaxy, you know\r\nYou know she's in love with me\r\nShe will go anywhere I go\r\nCan I have your daughter for the rest of my life?\r\nSay yes, say yes, 'cause I need to know\r\nYou say I'll never get your blessin' 'tll the day I die\r\n\"Tough luck, my friend, 'cause the answer's still no\"\r\nWhy you gotta be so rude?\r\nDon't you know I'm human too?\r\nWhy you gotta be so rude?\r\nI'm gonna marry her anyway\r\n(Marry that girl) marry her anyway\r\n(Marry that girl) no matter what you say\r\n(Marry that girl) and we'll be a family\r\nWhy you gotta be so rude?\r\nRude\r\nCan I have your daughter for the rest of my life?\r\nSay yes, say yes, 'cause I need to know\r\nYou say I'll never get your blessin' 'til the day I die\r\n\"Tough luck, my friend, but no still means no\"\r\nWhy you gotta be so rude?\r\nDon't you know I'm human too?\r\nWhy you gotta be so rude?\r\nI'm gonna marry her anyway\r\n(Marry that girl) marry her anyway\r\n(Marry that girl) no matter what you say\r\n(Marry that girl) and we'll be a family\r\nWhy you gotta be so rude?\r\nOh, yeah, oh\r\nWhy you gotta be so rude?\r\nWhy? (Yeah)\r\nWhy you gotta be so rude?");
            EN.Rows.Add("EN", Properties.Resources.When_I_Grow_Up, 0, "When I Grow Up", "NF", "4:00", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG NF - When I Grow Up.wav", "[Verse 1]\r\nYeah, when I grow up, you know what I wanna be?\r\nTake a seat, let me tell you my ridiculous dreams\r\nI wanna rap, yeah, I know it's hard to believe\r\nAnd I can tell you're already thinkin' I will never succeed\r\nBut I'm okay with it, I admit the lyrics are weak\r\nI've been workin' on 'em, I'll be good eventually\r\nI understand you gotta crawl before you get to your feet\r\nBut I been running for a while, they ain't ready for me, ahh\r\nI know this prolly isn't really realistic\r\nAnd honestly, I might not ever make a difference\r\nBut that don't make a difference, I'ma have to risk it\r\nI've been crunchin' numbers, you ain't gotta be a mathematician\r\nTo see the odds ain't rootin' for me\r\nI can't lie though, it's kinda how I like it to be\r\nThe underdog, yeah, you prolly think you know what I mean\r\nBut what I'm saying is they ever push me, I'm gonna swing, yeah\r\nI could go to college, get in debt like everybody else\r\nGraduate and prolly get a job that doesn't pay the bills\r\nThat don't make a lot of sense to me, forget the Happy Meals\r\nI don't like the dollar menu, I would rather make a meal\r\nHuh? Make a mil'? Nah, I said make a meal\r\nHome-cookin', get the grill, how you want it? Pretty well?\r\nEverything I see is overdone to me, I'm not Adele\r\nBut I'ma get a record deal and say hello to mass appeal\r\nYou might also like\r\nThe Search\r\nNF\r\nLie\r\nNF\r\nTime\r\nNF\r\n[Chorus]\r\nWhen I grow up, I just want to pay my bills\r\nRappin' about the way I feel (Oh, yeah)\r\nI just want to make a couple mil'\r\nLeave it to the fam in the will (Oh, yeah)\r\nI just want to sign a record deal\r\nMaybe buy a house up in the hills (Oh, yeah)\r\nMight not be the best in my field\r\nBut I guarantee that I'ma die real\r\nWhen I grow up\r\n\r\n[Post-Chorus]\r\nYeah, ayy\r\nWhen I grow up\r\nYeah, yeah, ayy\r\n\r\n[Verse 2]\r\nI'ma make 'em notice me, rhymin' like it's poetry\r\nEverything I oversee, I just like to overthink\r\nMockin' me, you pay the fee, no return and no receipts\r\nThose of you that don't believe, quiet, you don't know a thing\r\nQuiet when I'm tryna sing, quiet when I'm making beats\r\nQuiet when I'm tryna think, sorry, I don't mean to scream\r\nI just feel like no one really gets me and it's sad to see\r\n'Cause someday I'ma grow up and show all of you it's meant to be (Yeah)\r\nAnybody wanna hear me rap? \"No\"\r\nCome on, let me play a couple tracks, \"No\"\r\nCome on, I can spit it really fast, \"No\"\r\nYou think I should throw this in the trash? \"No\"\r\nTricked ya; haters, go away before I hit ya\r\nI am not a beggar or a kiss-up\r\nYou don't understand? Well, I forgive ya\r\nI am not a quitter, you ain't really think that, did ya?\r\nMaybe someday I could even be up on the radio\r\nHave a tour bus and maybe even play a couple shows\r\nEverybody in the crowd singing every word I wrote\r\nTellin' me that I am not the only one that feels alone\r\nHuh? You feel alone? Yeah, I kinda feel alone\r\nWonder if that feelin' ever goes away when you get old\r\nWill I ever make it as an artist? I don't really know\r\nMight not make a lot of dough\r\nI'ma have to try it, though\r\n[Chorus]\r\nWhen I grow up\r\nI just wanna pay my bills\r\nRappin' about the way I feel (Oh, yeah)\r\nI just wanna make a couple mil'\r\nLeave it to the fam in the will (Oh, yeah)\r\n(Leave it to the fam in the will)\r\n(Yeah, yeah, yeah, yeah)\r\nI just wanna sign a record deal\r\nMaybe buy a house up in the hills (Okay, oh, yeah)\r\nMight not be the best in my field (Ayy, ayy, yeah)\r\nBut I guarantee that I'ma die real\r\nWhen I grow up\r\nI just wanna pay my bills (Woo)\r\nRappin' about the way I feel (Oh, yeah)\r\n(Yeah, the way I feel)\r\nYeah, I just wanna make a couple mil' (Ayy, couple mil')\r\nLeave it to the fam in the will (Oh, yeah, to the fam in the will)\r\nI just wanna sign a record deal (Woo)\r\nMaybe buy a house up in the hills (Oh, yeah)\r\n(House up in the hills)\r\nYeah, I might not be the best in my field\r\nBut I guarantee that I'ma die real\r\nWhen I grow up\r\nWhen I grow up");
            EN.Rows.Add("EN", Properties.Resources.Counting_Stars, 0, "Counting Stars", "OneRepublic", "4:43", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG OneRepublic - Counting Stars.wav", "Lately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be counting stars\"\r\nYeah, we'll be counting stars\r\nI see this life, like a swinging vine\r\nSwing my heart across the line\r\nAnd in my face is flashing signs\r\nSeek it out and ye shall find\r\nOld, but I'm not that old\r\nYoung, but I'm not that bold\r\nAnd I don't think the world is sold\r\nOn just doing what we're told\r\nI feel something so right\r\nDoing the wrong thing\r\nAnd I feel something so wrong\r\nDoing the right thing\r\nI couldn't lie, couldn't lie, couldn't lie\r\nEverything that kills me makes me feel alive\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be counting stars\"\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be, we'll be counting stars\"\r\nYeah, yeah\r\nI feel your love, and I feel it burn\r\nDown this river, every turn\r\nHope is our four-letter word\r\nMake that money, watch it burn\r\nOld, but I'm not that old\r\nYoung, but I'm not that bold\r\nAnd I don't think the world is sold\r\nOn just doing what we're told\r\nAnd I feel something so wrong\r\nDoing the right thing\r\nI couldn't lie, couldn't lie, couldn't lie\r\nEverything that drowns me makes me wanna fly\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be counting stars\"\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be, we'll be counting stars\"\r\nOh, take that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nEverything that kills me makes me feel alive\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be counting stars\"\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be, we'll be counting stars\"\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned");
            EN.Rows.Add("EN", Properties.Resources.Deathbed, 0, "death bed", "Powfu", "2:53", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Powfu - death bed.wav", "Don't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed\r\nYeah, I don't wanna fall asleep, I don't wanna pass away\r\nI been thinking of our future, 'cause I'll never see those days\r\nI don't know why this has happened, but I probably deserve it\r\nI tried to do my best, but you know that I'm not perfect\r\nI been praying for forgiveness, you've been praying for my health\r\nWhen I leave this Earth, hoping you'll find someone else\r\n'Cause, yeah, we still young, there's so much we haven't done\r\nGetting married, start a family, watch your husband with his son\r\nI wish it could be me, but I won't make it out this bed\r\nI hope I go to Heaven, so I see you once again\r\nMy life was kinda short, but I got so many blessings\r\nHappy you were mine, it sucks that it's all ending\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed (yeah, ayy, ayy)\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed (ayy, yeah)\r\nI'm happy that you here with me, I'm sorry if I tear up\r\nWhen me and you were younger, you would always make me cheer up\r\nTaking goofy videos and walking through the park\r\nYou would jump into my arms every time you heard a bark\r\nCuddle in your sheets, sing me sound asleep\r\nAnd sneak out through your kitchen at exactly 1:03\r\nSundays, went to church, on Mondays, watched a movie\r\nSoon you'll be alone, sorry that you have to lose me\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed");
            EN.Rows.Add("EN", Properties.Resources.Stressed_Out, 0, "Stressed out", "twenty one pilot", "3:45", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG twenty one pilots - Stressed Out.wav", "I wish I found some better sounds no one's ever heard\r\nI wish I had a better voice that sang some better words\r\nI wish I found some chords in an order that is new\r\nI wish I didn't have to rhyme every time I sang\r\nI was told when I get older, all my fears would shrink\r\nBut now I'm insecure, and I care what people think\r\nMy name's Blurryface and I care what you think\r\nMy name's Blurryface and I care what you think\r\nWish we could turn back time\r\nTo the good old days\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out (oh)\r\nWish we could turn back time (oh)\r\nTo the good old days (oh)\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out\r\nWe're stressed out\r\nSometimes a certain smell will take me back to when I was young\r\nHow come I'm never able to identify where it's coming from?\r\nI'd make a candle out of it if I ever found it\r\nTry to sell it, never sell out of it, I'd probably only sell one\r\nIt'd be to my brother, 'cause we have the same nose\r\nSame clothes, homegrown, a stone's throw from a creek we used to roam\r\nBut it would remind us of when nothing really mattered\r\nOut of student loans and tree house homes, we all would take the latter\r\nMy name's Blurryface and I care what you think\r\nMy name's Blurryface and I care what you think\r\nWish we could turn back time\r\nTo the good old days\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out (oh)\r\nWish we could turn back time (oh)\r\nTo the good old days (oh)\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out\r\nUsed to play pretend, give each other different names\r\nWe would build a rocket ship and then we'd fly it far away\r\nUsed to dream of outer space, but now they're laughing at our face saying\r\n\"Wake up, you need to make money\", yeah\r\nWe used to play pretend, give each other different names\r\nWe would build a rocket ship and then we'd fly it far away\r\nUsed to dream of outer space, but now they're laughing at our face saying\r\n\"Wake up, you need to make money\", yeah\r\nWish we could turn back time\r\nTo the good old days\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out (oh)\r\nWish we could turn back time (oh)\r\nTo the good old days (oh)\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out\r\nWe used to play pretend, used to play pretend, money\r\nWe used to play pretend, wake up, you need the money\r\nUsed to play pretend, used to play pretend, money\r\nWe used to play pretend, wake up, you need the money\r\nUsed to play pretend, give each other different names\r\nWe would build a rocket ship and then we'd fly it far away\r\nUsed to dream of outer space, but now they're laughing at our face saying\r\n\"Wake up, you need to make money\", yeah");
        }
        private void EDMLoad()
        {
            EDM.Columns.Add("theloai", typeof(string));
            EDM.Columns.Add("hinhanh", typeof(object));
            EDM.Columns.Add("liked", typeof(string));
            EDM.Columns.Add("tenbaihat", typeof(string));
            EDM.Columns.Add("tencasi", typeof(string));
            EDM.Columns.Add("thoiluong", typeof(string));
            EDM.Columns.Add("binhluan", typeof(string));
            EDM.Columns.Add("baihat", typeof(string));
            EDM.Columns.Add("loibaihat", typeof(string));
            // the loai - hinh anh -ten bai hat - ten ca si - thoi luong - bai hat - lyric

            EDM.Rows.Add("EDM", Properties.Resources.Heads_Will_Roll, 0, "Heads Will Roll", "Amfree & Ampris", "2:20", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Amfree & Ampris - Heads Will Roll.wav", "Off with your head\r\nDance til you're dead\r\nHeads will roll\r\nHeads will roll\r\nHeads will roll\r\nOn the floor\r\nGlitter on the wet streets\r\nSilver over everything\r\nThe river's all wet\r\nYou're all chrome\r\nDripping with alchemy\r\nShiver stop shivering\r\nThe glitter's all wet\r\nYou're all chrome\r\nThe men cry out the girls cry out\r\nThe men cry out the girls cry out\r\nThe men cry out, oh no\r\nThe men cry out the girls cry out\r\nThe men cry out the girls cry out\r\nThe men cry out, oh no\r\nOh oh! Oh!\r\nOh oh! Oh!\r\nOff, off with your head\r\nDance, dance til you're dead (dead)\r\nHeads will roll\r\nHeads will roll\r\nHeads will roll\r\nOn the floor\r\nLooking glass\r\nTake the past\r\nShut your eyes\r\nRealize\r\nLooking glass\r\nTake the past\r\nShut your eyes\r\nRealize\r\nGlitter on the wet streets\r\nSilver over everything\r\nThe river's all wet\r\nYou're all chrome\r\nYou're all chrome\r\nOh!\r\nOh oh!\r\nOff, off, off with your head\r\nDance, dance dance til you're dead\r\nOff, off, off with your head\r\nDance, dance, dance til you're dead\r\nOff, off, off with your head\r\nDance, dance, dance til you're dead\r\nOff, off, off with your head\r\nDance, dance, dance til you're dead\r\nOff, off, off with your head\r\nDance, dance, dance til you're dead\r\nOff, off, off with your head\r\nDance, dance, dance til you're dead");
            EDM.Rows.Add("EDM", Properties.Resources.Waiting_For_Love, 0, "Waiting For Love", "Avicii", "3:50", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Avicii - Waiting For Love.wav", "Where there's a will, there's a way, kind of beautiful\r\nAnd every night has its day, so magical\r\nAnd if there's love in this life, there's no obstacle\r\nThat can't be defeated\r\nFor every tyrant, a tear for the vulnerable\r\nIn every lost soul, the bones of a miracle\r\nFor every dreamer, a dream, we're unstoppable\r\nWith something to believe in\r\nMonday left me broken\r\nTuesday, I was through with hoping\r\nWednesday, my empty arms were open\r\nThursday, waiting for love, waiting for love\r\nThank the stars, it's Friday\r\nI'm burning like a fire gone wild on Saturday\r\nGuess I won't be coming to church on Sunday\r\nI'll be waiting for love, waiting for love to come around\r\nWe are one of a kind, irreplaceable\r\nHow did I get so blind and so cynical?\r\nIf there's love in this life, we're unstoppable\r\nNo, we can't be defeated\r\nMonday left me broken\r\nTuesday, I was through with hoping\r\nWednesday, my empty arms were open\r\nThursday, waiting for love, waiting for love\r\nThank the stars, it's Friday\r\nI'm burning like a fire gone wild on Saturday\r\nGuess I won't be coming to church on Sunday\r\nI'll be waiting for love, waiting for love to come around");
            EDM.Rows.Add("EDM", Properties.Resources.If_Only_I_Could, 0, "If Only I Could", "Brooks", "4:22", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Brooks - If Only I Could.wav", "Stronger than a brick house\r\nBigger than the moon and brighter than the stars\r\nIf I could move the mountains\r\nI would've known who you are\r\n'Cause I've been lookin' far a way to get lost in your eyes\r\nTryna find my way in this chaos\r\nIf I could walk on water\r\nI could've known who you are\r\nIf only I could be the one to say\r\nYou can't stop me now\r\n'Cause I've been lookin' for...\r\n'Cause I've been lookin' for...\r\nIf I'd shown you what I'm made of\r\nYou would've seen it into me\r\nIf I'd shown you what I'm made of\r\nMaybe you'll see into me\r\nFaster than a race car\r\nSharper than a knife and higher than the trees\r\nIf I'd shown you what I'm made of\r\nYou would've seen it into me\r\n'Cause I've been lookin' for a way to get lost in your eyes\r\nTryna find my way in this chaos\r\nIf I show you what I'm made of\r\nMaybe you'll see into me, to me\r\nYou're fallin'\r\nIf only I could be the one to say\r\nIf only I could be the one to say\r\nYou can't stop me now\r\n'Cause I've been lookin' for...\r\n'Cause I've been lookin' for...\r\nIf I'd shown you what I'm made of\r\nYou would've seen into me\r\nIf I'd shown you what I'm made of\r\nMaybe you'll see into me");
            EDM.Rows.Add("EDM", Properties.Resources.Journey, 0, "Journey", "Don Diablo", "3:13", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Don Diablo - Journey.wav", "Take me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me where you wanna go, go, go\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me where you wanna go, go, go\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go");
            EDM.Rows.Add("EDM", Properties.Resources.Where_Are_You_Now, 0, "Where Are You Now", "Lost Frequencies", "2:53", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Lost Frequencies - Where Are You Now.wav", "You're just like my favorite song going 'round and 'round my head\r\nLike my favorite song going 'round and 'round my head\r\nFive days on the freeway\r\nRiding shotgun with you (yeah, yeah)\r\nTwo hearts in the fast lane\r\nWe had big dreams in blue (yeah, yeah)\r\nPlaying Sweet Child O' Mine\r\nAnd I still feel that line\r\nWhere are you now?\r\nWhere are you now?\r\nHey, it's been too long\r\nToo long to go, my love\r\nWhere did we go wrong?\r\nToo late to turn around\r\nWhere are you now?\r\nWhere are you now?\r\nHey, it's been too long\r\nYou're just like my favorite song going 'round and 'round my head\r\nLike my favorite song going 'round and 'round my head\r\nYou're just like my favorite song going 'round and 'round my head\r\nLike my favorite song going 'round and 'round my head\r\nHey, it's been too long\r\nSome days I can feel it\r\nBut the feeling ain't all blue\r\nYou got me believing\r\nOne day you gotta come through\r\nLost in these city lights\r\n'Cause I can't sleep tonight\r\nWhere are you now?\r\nWhere are you now?\r\nHey, it's been too long\r\nToo long to go, my love\r\nWhere did we go wrong?\r\nToo late to turn around\r\nWhere are you now?\r\nWhere are you now?\r\nHey, it's been too long\r\nYou're just like my favorite song going 'round and 'round my head\r\nLike my favorite song going 'round and 'round my head\r\nYou're just like my favorite song going 'round and 'round my head\r\nLike my favorite song going 'round and 'round my head\r\nWhere are you now?\r\nWhere are you now?\r\nWhere are you now?\r\nWhere are you now?\r\nWhere are you now?");
            EDM.Rows.Add("EDM", Properties.Resources.Silence, 0, "Silence", "Marshmallow", "3:06", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Marshmello - Silence.wav", "Yeah, I'd rather be a lover than a fighter (fighter)\r\n'Cause all my life, I've been fighting\r\nNever felt a feeling of comfort, oh\r\nAnd all this time, I've been hiding\r\nAnd I never had someone to call my own, oh nah\r\nI'm so used to sharing\r\nLove only left me alone\r\nBut I'm at one with the silence\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been quiet for too long\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been silent for too long\r\nI've been quiet for too long\r\nI've been quiet for too long\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been quiet for too long\r\nI'm in need of a savior (savior), but I'm not asking for favors\r\nMy whole life, I've felt like a burden\r\nI think too much, and I hate it\r\nI'm so used to being in the wrong, I'm tired of caring\r\nLoving never gave me a home, so I'll sit here in the silence\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been quiet for too long\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been silent for too long\r\nI've been quiet for too long\r\nI've been quiet for too long\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been quiet for too long");
            EDM.Rows.Add("EDM", Properties.Resources.Leyla, 0, "Leyla", "Mesto", "3:07", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Mesto - Leyla.wav", "You were only 17\r\nLookin' at your window screen\r\nSweetest girl I've ever seen\r\nStraight up from a project dream\r\nYou were on the second floor\r\nI was right across from yours\r\nTwo different sides of war\r\nKinda like a west side story, now\r\nLeyla, I am in love with you, Leyla\r\nI'm comin' up any day now\r\nSo bust that window and come with me\r\nLeyla, get all your stuff and we'll break out\r\nBaby, I know what they'll say now\r\nBut I want you anyway\r\nBut I want you anyway\r\nBut I want you anyway\r\nNow we've turned 23\r\nYou've moved across town from me\r\nOur friends and family, wouldn't let us be happy\r\nI hear you're married now\r\nHear it ain't working out\r\nThey can't shut us down\r\nLeyla just tell me how and I'll be there\r\nYou are a goddess, I want you to know (oh-oh-oh-oh)\r\nI'll never forget you, I'll never let go\r\nYeah, I'll be comin' to get you\r\nLeyla, I am in love with you, Leyla\r\nI'm comin' up any day now\r\nSo bust that window and come with me\r\nLeyla, get all your stuff and we'll break out\r\nBaby, I know what they'll say now\r\nBut I want you anyway\r\nBut I want you anyway\r\nBut I want you anyway\r\nYou are a goddess, I want you to know (oh-oh-oh-oh)\r\nI'll never forget you, I'll never let go\r\nYeah, I'll be comin' to get you\r\nLeyla, I am in love with you, Leyla\r\nI'm comin' up any day now\r\nSo bust that window and come with me\r\nLeyla, get all your stuff and we'll break out\r\nBaby, I know what they'll say now\r\nBut I want you anyway\r\nBut I want you anyway\r\nLeyla, I am in love with you, Leyla\r\nI'm comin' up any day now\r\nSo bust that window and come with me\r\nLeyla, get all your stuff and we'll break out\r\nBaby, I know what they'll say now\r\nBut I want you anyway");
            EDM.Rows.Add("EDM", Properties.Resources.When_The_Suns_Gone, 0, "When The Sun's Gone", "Mike William", "2:58", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Mike Williams - When The Sun Is Gone.wav", "When the sun, when the sun, when the sun is gone\r\nHold me tight when you feel like it all goes wrong\r\nTogether we'll be okay\r\nWe're the light in the world when the sun is gone (Is gone)\r\nWe'll be running red lights till the end of the road\r\nGonna make it, you and I, baby, that I know\r\nBut I'll hold you tight in my arms when the sun is gone (Is gone)\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nHold you tight in my arms when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nHold you tight in my arms when the sun is gone (Is gone)\r\nFollow me, I know we'll find higher ground\r\nAs long as we are together\r\nFind the path through the light where the dusk fades out (fade out)\r\nWe'll be running red lights till the end of the road\r\nGonna make it, you and I, baby, that I know\r\nBut I'll hold you tight in my arms when the sun is gone (Is gone)\r\nWhen the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nHold you tight in my arms when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nHold you tight in my arms when the sun is gone\r\n");
            EDM.Rows.Add("EDM", Properties.Resources.Bullet_Waiting_For_Me, 0, "Bullet Waiting For Me", "Nikki Simmons", "4:51", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Nikki Simmons - Bullet Waiting For Me.wav", "Standing on the open shore, in a world of disarray\r\n'Cause the chaos is a warm embrace\r\nAs the fire hits my body and my conscience is consumed\r\nNothing left of me but you, yeah\r\nAnd dancin' with my demons through and through\r\nJust stare into the distance for a chance to come around, take it\r\n\r\nThe final destination is at hand and for the first time in forever\r\nI feel the resolution, yeah\r\nThe shoreline keeps a’rising up to me, looking for my revolution\r\nThis is my chance to breathe, yeah-ah-ah-ah!\r\n\r\nLooking on the edge of fantasy; It’s a crashing wall of thunder\r\nAnd the roar of what I wish to believe is the bullet waiting for me\r\n\r\nLooking on the edge of fantasy; It’s a crashing wall of thunder\r\nAnd the roar of what I wish to believe is the bullet waiting for me");
            EDM.Rows.Add("EDM", Properties.Resources.Roses, 0, "Roses", "The Chainsmokers", "3:50", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM The Chainsmokers - Roses.wav", "You brought one to my door\r\nStood there on the front porch\r\nThat was the beginning\r\nWe had those tires spinning\r\nDown to the green grass\r\nOutside of town\r\nWild and free, never slowing down\r\nI thought I needed you like air\r\nWe burned hot, burned out, like a flame\r\nBut in my head, you'll never fade\r\nYeah, we were classic\r\nMy dress, your leather jacket\r\nDidn't know how good we had it\r\nBut, boy, we had it\r\n14th of February, gotta feeling my heart still carries\r\nYeah, we didn't know it\r\nThought we could grow it\r\nBeautiful for a moment\r\nWe were roses\r\nWe were roses\r\nYou put one in my hair\r\nWe danced in the middle of nowhere\r\nYou and me all summer\r\nBright and living color\r\nMy lips were red\r\nYour eyes were blue\r\nAnd I thought I saw forever in you\r\nYeah, we were classic\r\nMy dress, your leather jacket\r\nDidn't know how good we had it\r\nBut, boy, we had it\r\n14th of February, gotta feeling my heart still carries\r\nYeah, we didn't know it\r\nThought we could grow it\r\nBeautiful for a moment\r\nWe were roses\r\nBut seasons had to change\r\nAnd like flowers they bloom and withered away\r\nYeah, we were classic\r\nMy dress, your leather jacket\r\nDidn't know how good we had it\r\nIt was so good while it lasted\r\nYeah, we were classic\r\nMy dress, your leather jacket\r\nDidn't know how good we had it\r\nBut, boy, we had it\r\n14th of February, gotta feeling my heart still carries\r\nYeah, we didn't know it\r\nThought we could grow it\r\nBeautiful for a moment\r\nWe were roses\r\nWe were beautiful for a moment, baby\r\nWe were roses\r\nWe were beautiful for a moment, baby\r\nWe didn't know it\r\nThought we could grow it\r\nBeautiful for a moment\r\nWe were roses");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelVN_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelVN.Font;
            labelVN.Font = new Font("Yu Gothic Medium", 18, FontStyle.Underline);
            labelVN.ForeColor = Color.Transparent;
        }

        private void labelVN_MouseLeave(object sender, EventArgs e)
        {
            var font = labelVN.Font;
            labelVN.Font = new Font("Yu Gothic Medium", 18, FontStyle.Regular);
            labelVN.ForeColor = Color.Gray;
        }

        private void labelVN_Click(object sender, EventArgs e)
        {
            flagvn = 1;
            flagen = 0;
            flagedm = 0;

            panelListMusic.Visible = true;
            panelInfo.Visible = false;
            labelCateBanner.Text = "Vietnam hits";
            labelCateCollect.Text = "VIetnamese music picked just for you";

            picList1.BackgroundImage = (Image)VN.Rows[0]["hinhanh"];
            labelList1.Text = VN.Rows[0]["tenbaihat"].ToString();
            labelList2.Text = VN.Rows[0]["tencasi"].ToString();
            labelList3.Text = VN.Rows[0]["tenbaihat"].ToString();
            labelList4.Text = VN.Rows[0]["thoiluong"].ToString();

            picList2.BackgroundImage = (Image)VN.Rows[1]["hinhanh"];
            labelList5.Text = VN.Rows[1]["tenbaihat"].ToString();
            labelList6.Text = VN.Rows[1]["tencasi"].ToString();
            labelList7.Text = VN.Rows[1]["tenbaihat"].ToString();
            labelList8.Text = VN.Rows[1]["thoiluong"].ToString();

            picList3.BackgroundImage = (Image)VN.Rows[2]["hinhanh"];
            labelList9.Text = VN.Rows[2]["tenbaihat"].ToString();
            labelList10.Text = VN.Rows[2]["tencasi"].ToString();
            labelList11.Text = VN.Rows[2]["tenbaihat"].ToString();
            labelList12.Text = VN.Rows[2]["thoiluong"].ToString();

            picList4.BackgroundImage = (Image)VN.Rows[3]["hinhanh"];
            labelList13.Text = VN.Rows[3]["tenbaihat"].ToString();
            labelList14.Text = VN.Rows[3]["tencasi"].ToString();
            labelList15.Text = VN.Rows[3]["tenbaihat"].ToString();
            labelList16.Text = VN.Rows[3]["thoiluong"].ToString();

            picList5.BackgroundImage = (Image)VN.Rows[4]["hinhanh"];
            labelList17.Text = VN.Rows[4]["tenbaihat"].ToString();
            labelList18.Text = VN.Rows[4]["tencasi"].ToString();
            labelList19.Text = VN.Rows[4]["tenbaihat"].ToString();
            labelList20.Text = VN.Rows[4]["thoiluong"].ToString();

            picList6.BackgroundImage = (Image)VN.Rows[5]["hinhanh"];
            labelList21.Text = VN.Rows[5]["tenbaihat"].ToString();
            labelList22.Text = VN.Rows[5]["tencasi"].ToString();
            labelList23.Text = VN.Rows[5]["tenbaihat"].ToString();
            labelList24.Text = VN.Rows[5]["thoiluong"].ToString();

            picList7.BackgroundImage = (Image)VN.Rows[6]["hinhanh"];
            labelList25.Text = VN.Rows[6]["tenbaihat"].ToString();
            labelList26.Text = VN.Rows[6]["tencasi"].ToString();
            labelList27.Text = VN.Rows[6]["tenbaihat"].ToString();
            labelList28.Text = VN.Rows[6]["thoiluong"].ToString();

            picList8.BackgroundImage = (Image)VN.Rows[7]["hinhanh"];
            labelList29.Text = VN.Rows[7]["tenbaihat"].ToString();
            labelList30.Text = VN.Rows[7]["tencasi"].ToString();
            labelList31.Text = VN.Rows[7]["tenbaihat"].ToString();
            labelList32.Text = VN.Rows[7]["thoiluong"].ToString();

            picList9.BackgroundImage = (Image)VN.Rows[8]["hinhanh"];
            labelList33.Text = VN.Rows[8]["tenbaihat"].ToString();
            labelList34.Text = VN.Rows[8]["tencasi"].ToString();
            labelList35.Text = VN.Rows[8]["tenbaihat"].ToString();
            labelList36.Text = VN.Rows[8]["thoiluong"].ToString();

            picList10.BackgroundImage = (Image)VN.Rows[9]["hinhanh"];
            labelList37.Text = VN.Rows[9]["tenbaihat"].ToString();
            labelList38.Text = VN.Rows[9]["tencasi"].ToString();
            labelList39.Text = VN.Rows[9]["tenbaihat"].ToString();
            labelList40.Text = VN.Rows[9]["thoiluong"].ToString();
        }

        private void labelENG_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelENG.Font;
            labelENG.Font = new Font("Yu Gothic Medium", 18, FontStyle.Underline);
            labelENG.ForeColor = Color.Transparent;
        }

        private void labelENG_MouseLeave(object sender, EventArgs e)
        {
            var font = labelENG.Font;
            labelENG.Font = new Font("Yu Gothic Medium", 18, FontStyle.Regular);
            labelENG.ForeColor = Color.Gray;
        }

        private void labelEDM_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelEDM.Font;
            labelEDM.Font = new Font("Yu Gothic Medium", 18, FontStyle.Underline);
            labelEDM.ForeColor = Color.Transparent;
        }

        private void labelEDM_MouseLeave(object sender, EventArgs e)
        {
            var font = labelEDM.Font;
            labelEDM.Font = new Font("Yu Gothic Medium", 18, FontStyle.Regular);
            labelEDM.ForeColor = Color.Gray;
        }

        private void labelENG_Click(object sender, EventArgs e)
        {
            flagvn = 0;
            flagen = 1;
            flagedm = 0;

            panelListMusic.Visible = true;
            panelInfo.Visible = false;
            labelCateBanner.Text = "English hits";
            labelCateCollect.Text = "English music picked just for you";

            picList1.BackgroundImage = (Image)EN.Rows[0]["hinhanh"];
            labelList1.Text = EN.Rows[0]["tenbaihat"].ToString();
            labelList2.Text = EN.Rows[0]["tencasi"].ToString();
            labelList3.Text = EN.Rows[0]["tenbaihat"].ToString();
            labelList4.Text = EN.Rows[0]["thoiluong"].ToString();

            picList2.BackgroundImage = (Image)EN.Rows[1]["hinhanh"];
            labelList5.Text = EN.Rows[1]["tenbaihat"].ToString();
            labelList6.Text = EN.Rows[1]["tencasi"].ToString();
            labelList7.Text = EN.Rows[1]["tenbaihat"].ToString();
            labelList8.Text = EN.Rows[1]["thoiluong"].ToString();

            picList3.BackgroundImage = (Image)EN.Rows[2]["hinhanh"];
            labelList9.Text = EN.Rows[2]["tenbaihat"].ToString();
            labelList10.Text = EN.Rows[2]["tencasi"].ToString();
            labelList11.Text = EN.Rows[2]["tenbaihat"].ToString();
            labelList12.Text = EN.Rows[2]["thoiluong"].ToString();

            picList4.BackgroundImage = (Image)EN.Rows[3]["hinhanh"];
            labelList13.Text = EN.Rows[3]["tenbaihat"].ToString();
            labelList14.Text = EN.Rows[3]["tencasi"].ToString();
            labelList15.Text = EN.Rows[3]["tenbaihat"].ToString();
            labelList16.Text = EN.Rows[3]["thoiluong"].ToString();

            picList5.BackgroundImage = (Image)EN.Rows[4]["hinhanh"];
            labelList17.Text = EN.Rows[4]["tenbaihat"].ToString();
            labelList18.Text = EN.Rows[4]["tencasi"].ToString();
            labelList19.Text = EN.Rows[4]["tenbaihat"].ToString();
            labelList20.Text = EN.Rows[4]["thoiluong"].ToString();

            picList6.BackgroundImage = (Image)EN.Rows[5]["hinhanh"];
            labelList21.Text = EN.Rows[5]["tenbaihat"].ToString();
            labelList22.Text = EN.Rows[5]["tencasi"].ToString();
            labelList23.Text = EN.Rows[5]["tenbaihat"].ToString();
            labelList24.Text = EN.Rows[5]["thoiluong"].ToString();

            picList7.BackgroundImage = (Image)EN.Rows[6]["hinhanh"];
            labelList25.Text = EN.Rows[6]["tenbaihat"].ToString();
            labelList26.Text = EN.Rows[6]["tencasi"].ToString();
            labelList27.Text = EN.Rows[6]["tenbaihat"].ToString();
            labelList28.Text = EN.Rows[6]["thoiluong"].ToString();

            picList8.BackgroundImage = (Image)EN.Rows[7]["hinhanh"];
            labelList29.Text = EN.Rows[7]["tenbaihat"].ToString();
            labelList30.Text = EN.Rows[7]["tencasi"].ToString();
            labelList31.Text = EN.Rows[7]["tenbaihat"].ToString();
            labelList32.Text = EN.Rows[7]["thoiluong"].ToString();

            picList9.BackgroundImage = (Image)EN.Rows[8]["hinhanh"];
            labelList33.Text = EN.Rows[8]["tenbaihat"].ToString();
            labelList34.Text = EN.Rows[8]["tencasi"].ToString();
            labelList35.Text = EN.Rows[8]["tenbaihat"].ToString();
            labelList36.Text = EN.Rows[8]["thoiluong"].ToString();

            picList10.BackgroundImage = (Image)EN.Rows[9]["hinhanh"];
            labelList37.Text = EN.Rows[9]["tenbaihat"].ToString();
            labelList38.Text = EN.Rows[9]["tencasi"].ToString();
            labelList39.Text = EN.Rows[9]["tenbaihat"].ToString();
            labelList40.Text = EN.Rows[9]["thoiluong"].ToString();
        }

        private void labelEDM_Click(object sender, EventArgs e)
        {
            flagvn = 0;
            flagen = 0;
            flagedm = 1;
            panelListMusic.Visible = true;
            panelInfo.Visible = false;
            labelCateBanner.Text = "EDM hits";
            labelCateCollect.Text = "EDM picked just for you";

            picList1.BackgroundImage = (Image)EDM.Rows[0]["hinhanh"];
            labelList1.Text = EDM.Rows[0]["tenbaihat"].ToString();
            labelList2.Text = EDM.Rows[0]["tencasi"].ToString();
            labelList3.Text = EDM.Rows[0]["tenbaihat"].ToString();
            labelList4.Text = EDM.Rows[0]["thoiluong"].ToString();

            picList2.BackgroundImage = (Image)EDM.Rows[1]["hinhanh"];
            labelList5.Text = EDM.Rows[1]["tenbaihat"].ToString();
            labelList6.Text = EDM.Rows[1]["tencasi"].ToString();
            labelList7.Text = EDM.Rows[1]["tenbaihat"].ToString();
            labelList8.Text = EDM.Rows[1]["thoiluong"].ToString();

            picList3.BackgroundImage = (Image)EDM.Rows[2]["hinhanh"];
            labelList9.Text = EDM.Rows[2]["tenbaihat"].ToString();
            labelList10.Text = EDM.Rows[2]["tencasi"].ToString();
            labelList11.Text = EDM.Rows[2]["tenbaihat"].ToString();
            labelList12.Text = EDM.Rows[2]["thoiluong"].ToString();

            picList4.BackgroundImage = (Image)EDM.Rows[3]["hinhanh"];
            labelList13.Text = EDM.Rows[3]["tenbaihat"].ToString();
            labelList14.Text = EDM.Rows[3]["tencasi"].ToString();
            labelList15.Text = EDM.Rows[3]["tenbaihat"].ToString();
            labelList16.Text = EDM.Rows[3]["thoiluong"].ToString();

            picList5.BackgroundImage = (Image)EDM.Rows[4]["hinhanh"];
            labelList17.Text = EDM.Rows[4]["tenbaihat"].ToString();
            labelList18.Text = EDM.Rows[4]["tencasi"].ToString();
            labelList19.Text = EDM.Rows[4]["tenbaihat"].ToString();
            labelList20.Text = EDM.Rows[4]["thoiluong"].ToString();

            picList6.BackgroundImage = (Image)EDM.Rows[5]["hinhanh"];
            labelList21.Text = EDM.Rows[5]["tenbaihat"].ToString();
            labelList22.Text = EDM.Rows[5]["tencasi"].ToString();
            labelList23.Text = EDM.Rows[5]["tenbaihat"].ToString();
            labelList24.Text = EDM.Rows[5]["thoiluong"].ToString();

            picList7.BackgroundImage = (Image)EDM.Rows[6]["hinhanh"];
            labelList25.Text = EDM.Rows[6]["tenbaihat"].ToString();
            labelList26.Text = EDM.Rows[6]["tencasi"].ToString();
            labelList27.Text = EDM.Rows[6]["tenbaihat"].ToString();
            labelList28.Text = EDM.Rows[6]["thoiluong"].ToString();

            picList8.BackgroundImage = (Image)EDM.Rows[7]["hinhanh"];
            labelList29.Text = EDM.Rows[7]["tenbaihat"].ToString();
            labelList30.Text = EDM.Rows[7]["tencasi"].ToString();
            labelList31.Text = EDM.Rows[7]["tenbaihat"].ToString();
            labelList32.Text = EDM.Rows[7]["thoiluong"].ToString();

            picList9.BackgroundImage = (Image)EDM.Rows[8]["hinhanh"];
            labelList33.Text = EDM.Rows[8]["tenbaihat"].ToString();
            labelList34.Text = EDM.Rows[8]["tencasi"].ToString();
            labelList35.Text = EDM.Rows[8]["tenbaihat"].ToString();
            labelList36.Text = EDM.Rows[8]["thoiluong"].ToString();

            picList10.BackgroundImage = (Image)EDM.Rows[9]["hinhanh"];
            labelList37.Text = EDM.Rows[9]["tenbaihat"].ToString();
            labelList38.Text = EDM.Rows[9]["tencasi"].ToString();
            labelList39.Text = EDM.Rows[9]["tenbaihat"].ToString();
            labelList40.Text = EDM.Rows[9]["thoiluong"].ToString();
        }

        private void labelLiked_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelLiked.Font;
            labelLiked.Font = new Font("Yu Gothic Medium", 10, FontStyle.Underline | FontStyle.Bold);
            labelLiked.ForeColor = Color.WhiteSmoke;
        }

        private void labelLiked_MouseLeave(object sender, EventArgs e)
        {
            var font = labelLiked.Font;
            labelLiked.Font = new Font("Yu Gothic Medium", 10, FontStyle.Regular | FontStyle.Bold);
            labelLiked.ForeColor = Color.Silver;
        }

        private void labelList1_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picList1.BackgroundImage;
            labelNowPlay.Text = labelList1.Text;
            labelNowArtist.Text = labelList2.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;
            if (flagvn == 1)
            {
                player.Stop();
                player.SoundLocation = VN.Rows[0]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(VN.Rows[0]["liked"]);
            }
            if (flagen == 1)
            {
                player.Stop();
                player.SoundLocation = EN.Rows[0]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EN.Rows[0]["liked"]);
            }
            if (flagedm == 1)
            {
                player.Stop();
                player.SoundLocation = EDM.Rows[0]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EDM.Rows[0]["liked"]);
            }
        }

        private void panelPlay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelList25_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picList7.BackgroundImage;
            labelNowPlay.Text = labelList25.Text;
            labelNowArtist.Text = labelList26.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;
            if (flagvn == 1)
            {
                player.Stop();
                player.SoundLocation = VN.Rows[6]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(VN.Rows[6]["liked"]);
            }
            if (flagen == 1)
            {
                player.Stop();
                player.SoundLocation = EN.Rows[6]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EN.Rows[6]["liked"]);
            }
            if (flagedm == 1)
            {
                player.Stop();
                player.SoundLocation = EDM.Rows[6]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EDM.Rows[6]["liked"]);
            }
        }

        private void labelList5_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picList2.BackgroundImage;
            labelNowPlay.Text = labelList5.Text;
            labelNowArtist.Text = labelList6.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;
            if (flagvn == 1)
            {
                player.Stop();
                player.SoundLocation = VN.Rows[1]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(VN.Rows[1]["liked"]);
            }
            if (flagen == 1)
            {
                player.Stop();
                player.SoundLocation = EN.Rows[1]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EN.Rows[1]["liked"]);
            }
            if (flagedm == 1)
            {
                player.Stop();
                player.SoundLocation = EDM.Rows[1]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EDM.Rows[1]["liked"]);
            }
        }

        private void labelList9_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picList3.BackgroundImage;
            labelNowPlay.Text = labelList9.Text;
            labelNowArtist.Text = labelList10.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;
            if (flagvn == 1)
            {
                player.Stop();
                player.SoundLocation = VN.Rows[2]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(VN.Rows[2]["liked"]);
            }
            if (flagen == 1)
            {
                player.Stop();
                player.SoundLocation = EN.Rows[2]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EN.Rows[2]["liked"]);
            }
            if (flagedm == 1)
            {
                player.Stop();
                player.SoundLocation = EDM.Rows[2]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EDM.Rows[2]["liked"]);
            }
        }

        private void labelList13_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picList4.BackgroundImage;
            labelNowPlay.Text = labelList13.Text;
            labelNowArtist.Text = labelList14.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;
            if (flagvn == 1)
            {
                player.Stop();
                player.SoundLocation = VN.Rows[3]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(VN.Rows[3]["liked"]);
            }
            if (flagen == 1)
            {
                player.Stop();
                player.SoundLocation = EN.Rows[3]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EN.Rows[3]["liked"]);
            }
            if (flagedm == 1)
            {
                player.Stop();
                player.SoundLocation = EDM.Rows[3]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EDM.Rows[3]["liked"]);
            }
        }

        private void labelList17_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picList5.BackgroundImage;
            labelNowPlay.Text = labelList17.Text;
            labelNowArtist.Text = labelList18.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;
            if (flagvn == 1)
            {
                player.Stop();
                player.SoundLocation = VN.Rows[4]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(VN.Rows[4]["liked"]);
            }
            if (flagen == 1)
            {
                player.Stop();
                player.SoundLocation = EN.Rows[4]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EN.Rows[4]["liked"]);
            }
            if (flagedm == 1)
            {
                player.Stop();
                player.SoundLocation = EDM.Rows[4]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EDM.Rows[4]["liked"]);
            }
        }

        private void labelList21_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picList6.BackgroundImage;
            labelNowPlay.Text = labelList21.Text;
            labelNowArtist.Text = labelList22.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;
            if (flagvn == 1)
            {
                player.Stop();
                player.SoundLocation = VN.Rows[5]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(VN.Rows[5]["liked"]);
            }
            if (flagen == 1)
            {
                player.Stop();
                player.SoundLocation = EN.Rows[5]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EN.Rows[5]["liked"]);
            }
            if (flagedm == 1)
            {
                player.Stop();
                player.SoundLocation = EDM.Rows[5]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EDM.Rows[5]["liked"]);
            }
        }

        private void labelList29_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picList8.BackgroundImage;
            labelNowPlay.Text = labelList29.Text;
            labelNowArtist.Text = labelList30.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;
            if (flagvn == 1)
            {
                player.Stop();
                player.SoundLocation = VN.Rows[7]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(VN.Rows[7]["liked"]);
            }
            if (flagen == 1)
            {
                player.Stop();
                player.SoundLocation = EN.Rows[7]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EN.Rows[7]["liked"]);
            }
            if (flagedm == 1)
            {
                player.Stop();
                player.SoundLocation = EDM.Rows[7]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EDM.Rows[7]["liked"]);
            }
        }

        private void labelList33_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picList9.BackgroundImage;
            labelNowPlay.Text = labelList33.Text;
            labelNowArtist.Text = labelList34.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;
            if (flagvn == 1)
            {
                player.Stop();
                player.SoundLocation = VN.Rows[8]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(VN.Rows[8]["liked"]);
            }
            if (flagen == 1)
            {
                player.Stop();
                player.SoundLocation = EN.Rows[8]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EN.Rows[8]["liked"]);
            }
            if (flagedm == 1)
            {
                player.Stop();
                player.SoundLocation = EDM.Rows[8]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EDM.Rows[8]["liked"]);
            }
        }

        private void labelList37_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picList10.BackgroundImage;
            labelNowPlay.Text = labelList37.Text;
            labelNowArtist.Text = labelList38.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;
            if (flagvn == 1)
            {
                player.Stop();
                player.SoundLocation = VN.Rows[9]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(VN.Rows[9]["liked"]);
            }
            if (flagen == 1)
            {
                player.Stop();
                player.SoundLocation = EN.Rows[9]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EN.Rows[9]["liked"]);
            }
            if (flagedm == 1)
            {
                player.Stop();
                player.SoundLocation = EDM.Rows[9]["baihat"].ToString();
                player.Play();
                int checklike = Convert.ToInt32(EDM.Rows[9]["liked"]);
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {           
            player.Stop();
        }

        private void labelList1_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelList1.Font;
            labelList1.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelList1.ForeColor = Color.DarkSlateGray;
        }

        private void labelList1_MouseLeave(object sender, EventArgs e)
        {
            var font = labelList1.Font;
            labelList1.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelList1.ForeColor = Color.DarkSlateGray;
        }

        private void labelList5_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelList5.Font;
            labelList5.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelList5.ForeColor = Color.DarkSlateGray;
        }

        private void labelList5_MouseLeave(object sender, EventArgs e)
        {
            var font = labelList5.Font;
            labelList5.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelList5.ForeColor = Color.DarkSlateGray;
        }

        private void labelList9_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelList9.Font;
            labelList9.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelList9.ForeColor = Color.DarkSlateGray;
        }

        private void labelList9_MouseLeave(object sender, EventArgs e)
        {
            var font = labelList9.Font;
            labelList9.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelList9.ForeColor = Color.DarkSlateGray;
        }

        private void labelList13_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelList13.Font;
            labelList13.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelList13.ForeColor = Color.DarkSlateGray;
        }

        private void labelList13_MouseLeave(object sender, EventArgs e)
        {
            var font = labelList13.Font;
            labelList13.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelList13.ForeColor = Color.DarkSlateGray;
        }

        private void labelList17_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelList17.Font;
            labelList17.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelList17.ForeColor = Color.DarkSlateGray;
        }

        private void labelList17_MouseLeave(object sender, EventArgs e)
        {
            var font = labelList17.Font;
            labelList17.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelList17.ForeColor = Color.DarkSlateGray;
        }

        private void labelList21_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelList21.Font;
            labelList21.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelList21.ForeColor = Color.DarkSlateGray;
        }

        private void labelList21_MouseLeave(object sender, EventArgs e)
        {
            var font = labelList21.Font;
            labelList21.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelList21.ForeColor = Color.DarkSlateGray;
        }

        private void labelList25_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelList25.Font;
            labelList25.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelList25.ForeColor = Color.DarkSlateGray;
        }

        private void labelList25_MouseLeave(object sender, EventArgs e)
        {
            var font = labelList25.Font;
            labelList25.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelList25.ForeColor = Color.DarkSlateGray;
        }

        private void labelList29_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelList29.Font;
            labelList29.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelList29.ForeColor = Color.DarkSlateGray;
        }

        private void labelList29_MouseLeave(object sender, EventArgs e)
        {
            var font = labelList29.Font;
            labelList29.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelList29.ForeColor = Color.DarkSlateGray;
        }

        private void labelList33_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelList33.Font;
            labelList33.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelList33.ForeColor = Color.DarkSlateGray;
        }

        private void labelList33_MouseLeave(object sender, EventArgs e)
        {
            var font = labelList33.Font;
            labelList33.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelList33.ForeColor = Color.DarkSlateGray;
        }

        private void labelList37_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelList37.Font;
            labelList37.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelList37.ForeColor = Color.DarkSlateGray;
        }

        private void labelList37_MouseLeave(object sender, EventArgs e)
        {
            var font = labelList37.Font;
            labelList37.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelList37.ForeColor = Color.DarkSlateGray;
        }

        private void picNowPlay_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = true;
            panelListMusic.Visible = false;
            switch (labelNowPlay.Text)
            {
                case "#AiChoAi":
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorMusic.Text = VN.Rows[0]["tenbaihat"].ToString();
                    labelDecorArtist.Text = VN.Rows[0]["tencasi"].ToString();
                    labelDecorArtistName.Text = "Singer";
                    labelLyrics.Text = "Sớm mai tỉnh dậy tôi lạc vào hư không\r\nĐôi tay níu lấy điều gì mà chờ mong\r\nNắng kéo mây về\r\nGió kéo đông về\r\nBuồn người thương kéo tôi về ngày yêu\r\nĐêm qua mơ thấy anh quay về\r\nÔm choàng nhau ấm áp đông qua\r\nThức giấc môi cười\r\nÔi là mơ thôi\r\nBuồn tôi ơi khi nào mày vơi\r\nAnh cứ đi đi tìm tình yêu mới\r\nTôi đứng đây ôm trọn tình yêu cũ\r\nNhắn gió mây gửi đến anh đôi lời\r\nSợi tơ duyên đứt đi rồi có nối lại được không\r\nAh anh chẳng thể nắm được duyên tình mặc dù luôn muốn giữ em cho riêng mình\r\nAnh chẳng thể giữ em lại đây mặc dù cô đơn vẫn cứ luôn bủa vây\r\nAnh biết trước hai ta phải xa nhau\r\nThêm lâu rồi niềm đau sẽ thêm sâu\r\nNhưng nếu ta xa nhau thì con tim này ai khâu\r\nAnh biết thời gian rồi vẫn qua\r\nThanh xuân cả hai rồi sẽ qua\r\nNhưng có những thứ cả hai chẳng thể xoá\r\nEm tồn tại trong anh là giấc mơ\r\nAnh đã tìm được em trong nỗi nhớ\r\nNhưng anh sống với hiện thực\r\nTình yêu còn đó chẳng kết thúc như giấc mơ\r\nEm đi qua như dòng chảy của dòng sông\r\nAnh là phiên đá cũ tự hỏi em về không\r\nEm đi qua dòng nước khác vẫn quanh anh\r\nNhưng anh lại cảm thấy nỗi cô đơn vẫn bao quanh\r\nAnh chẳng thể mua được thời gian\r\nChẳng thể yêu ngày hôm qua\r\nCâu chuyện giờ đã lật sang trang\r\nKết chuyện là anh nhìn em rời xa\r\nAnh cứ đi đi tìm tình yêu mới\r\nTôi đứng đây ôm trọn tình yêu cũ\r\nNhắn gió mây gửi đến anh đôi lời\r\nSợi tơ duyên đứt đi rồi có nối lại được không\r\nTừng giây phút\r\nNgày xưa đó\r\nNgười có nhớ\r\nNhớ\r\nNhớ\r\nNhớ không";
                    break;
                case "Không sao đâu":
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorMusic.Text = labelNowPlay.Text;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Singer";
                    labelLyrics.Text = "CAM:\r\nYeah, hôm nay là ngày thứ mấy ở trong tuần\r\nNhiều cần đã cháy, nhiều lần đã thấy trước được hồi kết nhưng không tuân\r\nMấy lần những cuộc gọi nhỡ và lỡ có buông lời nói mớ, \r\nCũng nhớ gì đâu khi sâu trong óc vẫn còn quá nhiều điều đáng sợ.\r\nMọi thứ dường như đang quá tầm kiểm soát.\r\nCảm giác thế giới qua mặt được em, giờ đã xa tầm liên lạc.\r\nRồi em lại check Facebook, \r\nThâm tâm lại tự trách giây phút em nể bản than mình quá nhiều, \r\nEm để bản than mình hóa liều, quá liều.\r\nĐã bao lâu nay sao em không về nhà ?\r\nCòn phải bao nhiêu đêm trôi qua để mà em thôi rề rà ?\r\nEm nghe lời khuyên và điên từ tối qua,\r\nĐâu phải mê cung nào cũng tìm được lối ra.\r\nEm hay suy tư và dư ra thời giờ,\r\nVà đôi khi em không say no, bao niềm vui ai mời hờ (okay)\r\nChi ra bao nhiêu mua giấc mơ ?\r\nChi ra bao nhiêu ?\r\n\r\nIT’S ALRIGHT,\r\nCòn bao nỗi buồn, mình đâu muốn phải giấu ai.\r\nKhông sao em à, do it, IT’S ALRIGHT.\r\nVừa khóc, vừa cười này. (I wish I cared a little bit more)\r\n\r\nGIMME YOUR SOUL AND THEN GIMME YOUR… X3\r\n\r\nSHYNASTY:\r\nLang thang, lang thang\r\nBiết bao nhiêu ngày tháng, tâm bình thản, chân lang thang.\r\nNhìn những đám mây vàng nhẹ nhàng trôi lãng đãng, nhịp nhàng, đơn giản, ta chỉ muốn được mãn nhãn.\r\nLan man, lan man\r\nĐèn vàng chạng vạng, âm thanh xung quanh vang vang.\r\nKhông gì giới hạn bạn, con tim băng như đang tan.\r\nNhững gì chung tần số, hãy tìm cách để lan sang.\r\nTôi được dạy là không được thử, dù chỉ một lần,\r\nĐặt những thứ thay đổi tâm trạng, chạm gần tới môi.\r\nTôi đã nói không với suy nghĩ này rất nhiều lần,\r\nNhưng khổ nỗi suy nghĩ này lại không nói gì với tôi.\r\nĐôi khi không nguy hiểm như là người ta nghĩ,\r\nChỉ là một chuyến đi, nhưng không mang theo vali.\r\nNhư trôi đi Paris (yeah), như trôi về Bali (yeah).\r\nChỉ là đang giải trí, không cầu kì hay xa xỉ.\r\nCó những lúc ta bị (what), khó tính là đa nghi\r\nCuốn vào sự ma mị, while I’m getting money.\r\nNhững cảm giác lạ kì, nó đến và rồi ra đi.\r\nChỉ đơn giản là vì, đó là hiệu ứng suy nghĩ.\r\n\r\nIT’S ALRIGHT,\r\nCòn bao nỗi buồn, mình đâu muốn phải giấu ai.\r\nKhông sao em à, do it, IT’S ALRIGHT.\r\nVừa khóc, vừa cười này. (I wish I cared a little bit more)\r\n\r\nGIMME YOUR SOUL AND THEN GIMME YOUR… X3";
                    break;
                case "Sài Gòn buồn quá em ơi":
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorMusic.Text = labelNowPlay.Text;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Rapper";
                    labelLyrics.Text = "Sài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi, em ơi\r\nSài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi\r\nSài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi, em ơi\r\nSài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi\r\n\r\nAnh biết\r\nSài Gòn có những đêm buồn thức trắng\r\nLy cafe sữa vẫn còn vị ngọt nơi đầu môi\r\nAnh biết\r\nLà anh biết tất cả bộn bệ ở nơi mình từng\r\nLàm sao có thể thay đổi\r\nKhi chẳng có người đi cùng đổi thay\r\nTình đầu là tình vụn vỡ\r\nNgày mà mình chưa từng gặp gỡ\r\nNgày hôm qua quá nhiều chuyện buồn\r\nTrong từng nhịp thở\r\nCứ mãi cho đến một ngày\r\nNgày bình thường vô tình gặp nhau\r\nThì mới biết tim đã rối bời\r\nChẳng phải em thì chẳng tìm được đâu\r\nTâm hồn anh thì già cỗi\r\nChưa từng một lần rực rỗi\r\nMỗi khi thấy chân em dừng lại\r\nXin một lần hỏi\r\nNắng chói chang khắp chiều tà\r\nHoàng hôn yên vị xong rồi lại đi\r\nEm là thuyền trưởng\r\nAnh sẽ căng buồm\r\nChẳng ngại vì gió lau nhẹ bờ mi\r\nĐể cho anh một lần được nói\r\nCho anh một lần được hỏi\r\nPhải chăng anh là điểm tựa\r\nĐể em dựa mỗi ngày mệt mỏi?\r\nĐể cho anh một lần được nói\r\nCho anh một lần được hỏi\r\nNếu một ngày không gặp anh nữa\r\nEm có vội vàng đi tìm anh không?\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi lạc thì xem như mất nhau!\r\nNgười vội bước còn người đang đứng sau\r\nCần một điều ước để vượt qua nỗi đau\r\nDù phút chốc Sài Gòn vẫn vui\r\nSao anh mãi buồn?\r\nSài Gòn tháng năm sau\r\nAnh không, không còn em nữa đâu\r\nGiận rồi người cũng xa nhau\r\nQuên nhau, không còn nghĩ đến nhau\r\nNgày buồn nhất là ngày ta vỡ tan\r\nNgười ngồi khóc\r\nCòn người đang trách than\r\nNgày này tháng ấy mình rời bỏ nhau\r\nTrong đêm mưa buồn\r\n\r\nVì tình yêu đã lỡ một nhịp\r\nĐành phải nhường lại cho người đến sau\r\nKhi anh chỉ còn một nhịp\r\nAnh chỉ muốn thở hết những nỗi đau\r\nAnh không tin vào định mệnh\r\nAnh tin vào ngày mai\r\nNếu anh không thể làm được điều gì nữa\r\nThì chắc lẽ là anh sai\r\nVà em nên nhớ\r\nTình yêu không thể\r\nĐếm bằng ngày đâu em\r\nĐó là tất cả những gì đọng lại\r\nSau nhưng đêm dài buồn không tên\r\nĐến khi cảm xúc thấu được mình đã\r\nTrải qua quá nhiều lần tổn thương\r\nChiếc gương ấy sẽ xóa được hình bóng ai\r\nĐã khiến lòng mình vấn vương\r\nDù sai, dù đúng\r\nTất cả cũng không quan trọng vì\r\nNgười đi, người đến người ở lại\r\nLà vì hiểu nhau thì\r\nNgày em buồn nhất\r\nAnh sẽ đứng lại dù trời có mưa\r\nVà anh muốn hỏi tất cả chuyện buồn\r\nEm đã cất chưa\r\nBình yên là lúc ta cùng nhìn lại\r\nNở một nụ cười cho dù đớn đau\r\nBình yên là lúc có người tồn tại\r\nLuôn nằm phía sau\r\nTình yêu đẹp nhất khi lòng thù hận\r\nEm cần vứt đi\r\nTình yêu chỉ đến sau những mảnh vụn\r\nCó kẻ ghép lại, lau nhẹ ướt mi\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi lạc thì xem như mất nhau!\r\nNgười vội bước còn người đang đứng sau\r\nCần một điều ước để vượt qua nỗi đau\r\nDù phút chốc Sài Gòn vẫn vui\r\nSao anh mãi buồn?\r\nSài Gòn tháng năm sau\r\nAnh không, không còn em nữa đâu\r\nGiận rồi người cũng xa nhau\r\nQuên nhau, không còn nghĩ đến nhau\r\nNgày buồn nhất là ngày ta vỡ tan\r\nNgười ngồi khóc\r\nCòn người đang trách than\r\nNgày này tháng ấy mình rời bỏ nhau\r\nTrong đêm mưa buồn\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi, lạc thì xem như mất nhau!\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi, lạc thì xem như mất nhau!";
                    break;
                case "Trốn tìm":
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorMusic.Text = labelNowPlay.Text;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Rapper";
                    labelLyrics.Text = "Có một cái cây trong một cái vườn\r\nTrên những tán cây nở rộ những đoá hoa\r\nCó hai đứa nhóc đang chơi trốn tìm\r\nTìm hoài tìm mãi nên quên lối về\r\nAnh đi tìm thì em trốn anh đi trốn em không tìm\r\nLòng em không gợn sóng cuối cùng anh mất công chìm\r\nNếu mà có cây búa anh sẽ nện cho bõ công\r\nVì nhớ nhung đặc quánh giờ nó khô thành bê tông\r\nChúng ta rồi sẽ có có những chuyến đi dài\r\nTa tự học lấy mọi thứ vì trong tình trường làm biếng ghi bài\r\nCâu chuyện của chúng ta bỗng có thêm một miếng bi hài\r\nVì cách mà em gọi anh không có u và thiếu y dài\r\nPhía xa thành phố người ta đã bật đèn đường\r\nHương quen xưa làm anh thấy thật thèm thuồng\r\nNỗi buồn vàng rực cứ như là chứa đồng thau\r\nHệt như là Beckham vậy em chỉ giỏi cứa lòng nhau\r\nHé cửa sổ ra mà xem\r\nCó một chàng thi sĩ đứng ở ngay nhà em\r\nViết nhạc tình mát ngọt tựa như cây cà rem\r\nAnh ta sẽ đứng ở nơi đây cả đêm\r\nCó hai cái cây trong một cái vườn (có hai cái cây trong vườn)\r\nTrên những tán cây nở rộ những đoá hoa (có những đoá hoa trên cành)\r\nCó hai đứa nhóc đang chơi trốn tìm (có hai đứa nhóc đang chơi)\r\nTìm hoài tìm mãi nên quên lối về\r\nHồi đó anh rụt rè như đám cây mắc cỡ\r\nGần em làm anh hồi hộp tới mức gây tắc thở\r\nTa đều không biết có điều gì sau đám mây sắp nở\r\nTrò chơi trốn tìm ngày đó sau này đầy trắc trở\r\nTa săn bắn những khát vọng và hái lượm những giấc mơ\r\nTa gieo trồng cây ước mộng thứ mà lấy đi nhiều thì giờ\r\nTa đào những cái hố mà không biết có ngày bị lọt\r\nĐể rất lâu sau này chúng ta cau mày nhận ra không phải tất cả bông hoa thì đều sẽ có những nhụy ngọt\r\nGọi tên em làm anh mất giọng hoài\r\nHệt như là một giấc mộng dài\r\nTa đi tìm cả thế giới nhưng mà lại trốn nhau\r\nBiết vậy thà nghỉ chơi từ lúc mới chớm đau (từ lúc mới chớm đau)\r\nNgười đi tìm cái người đi trốn\r\nNgười đi trốn cái người đi tìm\r\nTình yêu từ những ngày xưa đã\r\nNgủ quên dưới tán cây im lìm\r\nCó ba cái cây trong một cái cái vườn\r\nTrên những tán cây nở rộ những đoá hoa\r\nCó hai đứa nhóc đang chơi trốn tìm\r\nTìm hoài tìm mãi nên quên lối về\r\nAi đó đã chặt hết cây và cũng chẳng thấy vườn (chẳng thấy cây trong vườn)\r\nAi đó đã xây một ngôi nhà rất to (chặt hết cây đi rồi)\r\nChắc em hạnh phúc yên vui với người (chắc em hạnh phúc yên vui)\r\nNhà em có chó anh không dám vào\r\nNiềm cô đơn của những người trưởng thành\r\nLà khi muốn trốn nhưng không ai tìm\r\nNhiều khi ta muốn ta được bé lại\r\nĐể khi đi trốn có người đi tìm\r\nNhiều khi ta muốn ta được bé lại\r\nĐể khi đi trốn có người đi tìm";
                    break;
                case "Loving You Sunny":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Singer/Rapper";
                    labelLyrics.Text = "Thoát ra mối sầu đêm nay\r\nCho em gối đầu lên tay\r\nKhông cần thuê người tư vấn\r\nYên tâm mình sẽ tự phối màu thêm hay\r\nAnh sẽ pha màu nhạt khói\r\nVào màu trầm của môi em\r\nVà nếu bên nhau là lạc lối\r\nThì mình cứ để mọi thứ kia trôi êm\r\nI wish you could give me another chance\r\nHave you ever thought of us as a future plan\r\nInside my heart, I know I don't wanna give up\r\nUntil i can have your love\r\nI know it worths it baby\r\nI know what makes me happy is you\r\nNobody could\r\nKiss me like the way you do\r\nThe way you talk to me, yeah\r\nI don't need no drugs only your love make me feel that high\r\nSunny that's why I love you\r\nOnly you can make me feel, in love again\r\nPicture me in the battle, finding you again\r\nI can feel a sunshine, in me one more time\r\nWhenever I see yo green eyes\r\nThats why I love you sunny\r\nHere's my heart just take it everywhere you go\r\nDestiny will bring me back to you for show\r\nWoah, I know you got everything i want\r\nIf you still love me\r\nGive me a chance\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h-oh-oh, Sunny\r\nYou\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h oh-oh, Sunny\r\nYou\r\nYou're amazing you're unique\r\nAnd you're bad\r\nYour lifestyle, interesting, passionate\r\nAnd I adore you\r\nBy the way you carry yourself\r\nBabe, you do it so well\r\nAnd I like that, like that\r\nI wanna show you my real world\r\nNo acting up, no playing games\r\nNo wall\r\nJust spend with me and u will see\r\nWe are meant to be\r\nCause i'm your baby\r\nOnly you can make me feel in love again\r\nPicture me in the battle, finding you again\r\nI can feel a sunshine in me one more time\r\nWhenever I see yo green eyes\r\nThats why I love you sunny\r\nHere's my heart just take it everywhere you go\r\nDestiny will bring me back to you for show\r\nWoah, I know you got everything i want\r\nIf you still love me\r\nGive me a chance\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h-oh-oh, Sunny\r\nYou\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h oh-oh, Sunny\r\nYou\r\nEm không cần mặc đẹp, vì anh thích lôi thôi\r\nGiam em bằng vòng tay rộng và\r\nTra tấn em bằng đôi môi\r\nLòng mình vui như tết á\r\nKhông cần chờ đêm ba mươi\r\nThả mình vào trong biển lớn\r\nKhông cần buồm mà ra khơi\r\nVì mình có quá nhiều ngày cô đơn nên ngày bên em dường như là không đủ\r\nMình sẽ phải cần thêm nhiều cà phê hơn\r\nVì đêm nay chúng ta sẽ không ngủ\r\nAnh sẽ vặn ngược lại kim của đồng hồ\r\nĐể nó luôn chỉ thời khắc nửa đêm\r\nTa sẽ có một ngày dài như là thế kỷ như vậy mới đủ để cho anh hiểu em\r\nNói lời chân thật với nhau, đừng bắt tâm tư phải sàng và lọc\r\nEm cần may túi ba gang vì lúc bên nhau là vàng là ngọc\r\nCó hàng tá rapper ngoài kia nhưng sẽ không có một Đen thứ hai\r\nViết cho em những điều kì lạ, em sẽ nhận ra chỉ Đen chứ ai\r\nBởi vì anh không thích đồ ngọt nên hãy yêu nhau theo cách mặn mà\r\nCứ yên tâm nhạc tình Đen viết luôn đặc quánh và rất đậm đà\r\nChắt chiu như trong một sớm trên lá đọng vệt trong ngần sương\r\nYêu em như cách anh viết nhạc, luôn cần mẫn mà không cần lương\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h-oh-oh, Sunny\r\nYou\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h oh-oh, Sunny\r\nYou";
                    break;
                case "Chuyện chàng trông xe":
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorMusic.Text = labelNowPlay.Text;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Rapper";
                    labelLyrics.Text = "một toán học sinh lại đến\r\ncầm phấn viết lên yên xe\r\n24 25 biết khi nào xong\r\n“Xe em cho thẳng vào trong nhé”\r\nVina còn chưa kịp châm\r\ntrà đá vẫn chưa kịp nhấp môi\r\nTrời sập tối mưa rào\r\n\r\ndòng xe chắp nối đưa vào\r\n\r\nvà em \r\nsố xe 07 em ra mà xem\r\n\r\nlàm anh nhớ mong cả đêm\r\n\r\nthế nhưng cái tên lại quên\r\nvà anh\r\nlàm nghề cầm phấn nhưng không ai nghe\r\nBa anh lái xe bảo học không nghe\r\nthế nên giờ đây số kiếp trông xe\r\nđừng làm anh mong nhớ\r\nsánh đôi có lẽ chỉ ở trong mơ thôi\r\nchạm mặt em xong lỡ\r\ntrái Tim vụn vỡ lại đập loạn nhịp mong chờ\r\n\r\nsinh ra ở khu lao động không đi trông xe thì cũng xách vữa\r\nphổ biến là làm lao công còn muốn nghèo có thêm chục cách nữa\r\nBố mẹ anh không đủ tiền cho anh đi học cùng bạn trang lứa\r\nCây phấn mỗi ngày anh dùng phủ cuộc đời anh trắng thêm trang nữa\r\nđồng phục, tóc búi, cười hiền đi converse và em sơ vin\r\nlướt qua là anh muốn cưới, lấy giấy tờ, bỏ vào all in ô in\r\nEm như cây bút chì màu vẽ cuộc đời anh ở khung hình riêng\r\nThơ ngay 1 chút tình đầu anh muốn xoá bỏ đi những định kiến\r\nbố mẹ vẫn bảo anh là “sao mày đũa mốc mà chòi mâm son”\r\nhọc toán còn chưa ăn ai bây h mày thích học đòi không con\r\nmuốn đưa vé xe cho em nhưng anh lại sợ làm dơ áo trắng\r\nGiọng em ngọt như kem làm cổ họng anh tự nhiên nó đắng\r\n\r\ntương tư về em mỗi đêm cùng với thăng long anh lười không ngủ\r\ntưởng như chỉ yêu mỗi em dưới ánh trăng cong chửi “người âm phủ”\r\nmấy thằng con trai miệng lưỡi dẻo quẹo thì xin em đừng cả tin\r\nngoài đời thì nó thả bả còn lên mạng thì nó thả tim\r\n1 túp lều tranh 2 trái Tim vàng thì chắc bây giờ không có\r\nNgày 2 chúng ta yêu nhau thì chắc là ngày mặt trời không ló\r\nbố mẹ em cần ví dày nhưng giống bụng anh ví anh lép kẹp\r\nnhà anh có mỗi cửa sổ nên chuyện tình mình giờ chắc khép đẹp\r\n\r\n";
                    break;
                case "Anh không thề gì đâu anh làm":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Singer/Rapper";
                    labelLyrics.Text = "Ngày tháng có em bên cạnh trôi qua như một cơn mơ nhanh\r\nAnh có phải là bắp rang đâu mà em bơ anh\r\nEm ơi, xin đừng giận anh, đừng làm khó thêm\r\nTrong tim anh em như là Hawkeye, vì em luôn có tên\r\nEm luôn đứng đầu, em luôn đứng đầu\r\nDù em như bị trúng gió, em cứng cổ và cứng đầu\r\nAnh yêu em và nhiều đêm, tương tư anh lại nhiều thêm\r\nNgười ta thích là chiều ta, còn anh thì chỉ thích chiều em\r\nBên cạnh em anh luôn là khó ngầu\r\nVì nếu tim anh là mùa xuân, em là cơn gió đầu\r\nNghĩ về em cả hàng giờ, anh không mong tim em có sầu\r\nYêu em như một bàn cờ, anh mong kết cục có hậu\r\nTa cạn say, chén rượu xuân cay nồng và ngắm cánh nhạn bay\r\nChuyện tình ta như Iphone, mở ra từ cái chạm tay\r\nAnh không muốn thấy đạn bay và tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không muốn thấy đạn bay, tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm\r\nAnh nói thật là anh ghét nhất những lần ta cãi vã\r\nKhông phải chuyển giới nhưng đôi lúc anh thấy em thái quá\r\nĐâu là lí do đấy là thứ anh còn tìm\r\nNhiều lúc không biết anh đang yêu em hay anh đang chơi dò mìn\r\nNgày mà em giận, anh thấy u ám như ngày mưa\r\nSợ tình ta sẽ phải úa tàn như là vườn hồng ngày xưa\r\nĐến với em anh ôm hi vọng còn mưu mẹo thì quên đem\r\nĐếch cần 36 kế, anh chỉ cần kế bên em\r\nThương em từ sáng tới lúc trời tối đen thui\r\nHọ gọi anh là MC nhưng anh chỉ muốn làm em vui\r\nNên dù em đã nhận lời yêu anh vẫn còn thèm cưa em\r\nEm không đẹp như siêu mẫu mà siêu mẫu họ đẹp như em\r\nTừ ngày hẹn hò em làm anh thêm thói quen\r\nGiờ anh thích ăn kem vì trong kem có em\r\nEm cứ yên tâm, anh sẽ không để tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không muốn thấy đạn bay, tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm";
                    break;
                case "Trên Lầu Cao":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Rapper";
                    labelLyrics.Text = "Money flows in, money flows out\r\nBeware of the fishin' round it\r\nTao đi đường riêng\r\nCho dù còn bao nhiêu là ánh mắt vẫn đang liếc đi theo rình\r\n(Haters thì sao?)\r\nHaters thì sao?\r\nHỏi thằng nào mà không biết tên tao?\r\nTao mải là tao nên chưa kịp tiếp thằng nào\r\nMuốn được biết thì xuống tít bên dưới xếp hàng mau (Lineup)\r\nLife's the peephole (Yeah)\r\nYou see what your mind wanna believe though (No lie)\r\nNên tao đâu cần đi đầu (Nope)\r\nCứ đi theo lời mách bảo trong lí trí tao (That's right)\r\nYeah, cũng có lúc tao lạc mất tiết tấu\r\nYeah, cũng có lúc nhịp tao lơi\r\nVẫn lean on xuống deep low\r\nĐể nhịp swing bám vào beat và lời\r\n(Nhịp swing bám vào beat và lời)\r\n(Nhịp swing bám vào beat và lời)\r\nYeah\r\nVà khi sang ngày mới những vương bận chỉ còn là nốt nhạc cũ rích mà thôi (move up)\r\nĐạp mạnh chân ga cho bô nhả khói\r\nĐâu ai đi lạc lối cả đời?\r\nTầm nhìn mày liệu có vươn xa tới?\r\nHay là trên lời nói đầu môi?\r\nVạn vật đổi dời\r\nTao đâu dừng chân chờ ngày tàn kia đuổi tới\r\nTao đâu ngồi than khi thời gian đang tuột trôi\r\nBao nhiêu ngổn ngang đâu cần mang theo cuộc chơi?\r\nCàng nhiều buộc trói\r\nMày có thở nổi khi càng ngày càng lên cao?\r\nKhông gian càng loãng những cám dỗ càng biến ảo\r\nVà nếu mày không biết tao\r\nChắc mày nghĩ đây chỉ là câu chuyện hão (Yeah)\r\nNhạc high as em nghe theo bao nhiêu lâu? (Low)\r\nUnderground nhưng phát ở trên tầng lầu (low)\r\nSo high I paralyzed from down below (low)\r\nUnderground getting down with top flo' (low)\r\nLà underground trên lầu cao\r\n(It's how we roll around here)\r\nUnderground trên lầu cao\r\n(It's high level now)\r\nUnderground trên lầu cao\r\n(It's how we roll around here)\r\nLà underground trên lầu cao\r\nĐời ngắn có lúc đắng có lúc say\r\nChỉ sợ là mình lắm lúc mất trắng những phút giây\r\nNhiều người chìm đắm bao nhiêu năm vẫn cứ vậy\r\nThì liệu mày còn buồm căng qua vũng lầy?\r\nHay là mày thích nghe kể khổ?\r\nThích nghe kể nghèo?\r\nThích an ủi mình chùn tay?\r\nĐể rồi rả rích điệp khúc cũ\r\n\"Vì đời lắt léo thì mới chọn đường cùng này\"\r\nĐâu cần vạch đích để biết mình đang chạy\r\nCần gì thành tích để khích mình hăng say\r\nĐời người thành bại đều do mình giằng lấy\r\nKẻ vươn xa người đứng lại đều nằm ở tầm tay\r\nVì ngày mai biết được ai sẽ bị thay mới\r\nDại gì phí hoài để tương lai trôi\r\nKiếp này được vươn vai để mày trải đời\r\nLiệu mày có lại ngồi dưới đáy than đời phai phôi?\r\nVì sẽ có kẻ chỉ nói mà không làm\r\nNgười càng đói lại càng thích phàn nàn\r\nThành công vang dội thì cần gì lan man\r\nKhi chẳng cần nhiều lời miệng đời vẫn bàn tán\r\nDù lòng mày còn vướng bận, nghiệp mày còn gian nan\r\nThì cứ lấy danh dự làm la bàn\r\nChỉ cần nhớ được rằng, đêm tối dù hoạn nạn\r\nĐừng quay lưng khi mày tỏa sáng\r\nNên sân khấu này bật xuyên đêm\r\nNơi tao đứng Spaceboys luôn thức\r\nTúc trực cho những người anh em\r\nMượn lời bằng nhạc dắt nhau tới tận cùng\r\nAi cũng có thể được mời đến\r\nNhưng bản lĩnh mới được ngồi bàn trong\r\nVì tiền ở đây tha hồ đếm, khi có trình độ đúc từ vàng ròng\r\nNhạc high as em nghe theo bao nhiêu lâu? (Bao nhiêu lâu?)\r\nUnderground nhưng phát ở trên tầng lầu (Trên tầng lầu)\r\nSo high I paralyzed from down below (Chears to all my brothers and sisters)\r\nUnderground getting down with top flo'\r\nGet down!\r\nUnderground trên lầu cao\r\n(It's how we roll around here)\r\nUnderground trên lầu cao\r\n(It's high level now)\r\nUnderground trên lầu cao\r\n(It's how we roll around here)\r\nLà underground trên lầu cao";
                    break;
                case "Nhập gia tùy tục":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Rapper";
                    labelLyrics.Text = "You know me\r\nYou know me, yeah\r\nNgồi lên ngựa sắt\r\nLái qua phố riêng mình ta\r\nTrên chiến trường\r\nNhưng đang hát tình ca\r\nNgười đánh giá ta\r\nQua vài tấm hình mà\r\nÔng bà đã nói\r\nPhải biết trông rộng nhìn xa\r\nLập chiến tích không gây chiến tranh\r\nHoàn thành rồi anh em mình biến nhanh\r\nNhập gia thì tùy tục\r\nAnh hiền, ừ cũng tùy lúc\r\nMái đầu 7/3 cầm cây guitar rồi gảy ra\r\nĐứng yên như cột cờ nhưng ai ai cũng thấy ta\r\nKhông phải vận động viên nhưng mùa này anh nhảy xa\r\nÁp lực nặng như đá, ta là nước cứ chảy qua\r\nSăn tiền thưởng như cao bồi, uh\r\nAnh em đều có phần đam mê được trau dồi\r\nChẳng cần bước lên cao ngồi\r\nNói anh thất bại giờ mấy đứa nó sao rồi\r\nOn top ở trên tuần báo\r\nLấy tên tuổi cho thằng em bán quần áo\r\nLàm cho cả băng DCOD giá trị gia tăng\r\nỞ trong khu có người tự hào, thằng đó là bạn mình\r\nCòn nụ cười khinh thì anh coi như nó đang tàng hình\r\nFly Team, bay một đàn như loài chim\r\nĐể lại dấu ấn trên da như ngòi kim\r\nTừ đời thiệt ra lời viết\r\nHiên ngang giữa mọi thời tiết\r\nDòng đời và âm nhạc\r\nMuốn anh phải liều lĩnh\r\nThời gian là tiền bạc anh cần phải điều chỉnh\r\nNgồi lên ngựa sắt\r\nLái qua phố riêng mình ta\r\nTrên chiến trường\r\nNhưng đang hát tình ca\r\nNgười đánh giá ta\r\nQua vài tấm hình mà\r\nÔng bà đã nói\r\nPhải biết trông rộng nhìn xa\r\nMình tiến lên trong cuộc chơi mọi thứ an bài\r\nTui làm nhạc ông mê đá banh anh em ngang tài\r\nMàu cờ anh đưa lên thang dài\r\nĐón em anh đem vào trang đài\r\nBuổi sáng đang soi mái đầu anh chải\r\nChiều em mặc đồ bơi bên biển xanh mãi\r\nTối đi nghe nhạc để sầu nhanh giải\r\nBỏ ngoài tai trên mạng còn nhiều tranh cãi\r\nVẫn chờ người về đây ta cùng bay đến tương lai\r\nSợ gì vài cây, ngựa hay phải chạy đường dài\r\nNhư Cowboy viễn Tây đôi tay nhanh hơn chướng ngại\r\nKhông cần sắt đá ta vẫn xây nên tượng đài\r\nYou know I'm keeping my weapon like a soldier\r\nGiữa chặng đường dừng lại hét lên thử thách anh đâu sợ\r\nChẳng hề độc bước gia đình anh em ở sau chờ\r\nMỗi lần buồn phiền hãy ngước lên gọi Hallelujah\r\nTrôi dạt mênh mông như mây ở trên không\r\nGiọng anh trầm, yeah anh không cần lên tone\r\nGiọng anh trầm, yeah anh không cần lên tone\r\nAnh không cần lên tone\r\nNgồi lên ngựa sắt\r\nLái qua phố riêng mình ta\r\nTrên chiến trường\r\nNhưng đang hát tình ca\r\nNgười đánh giá ta\r\nQua vài tấm hình mà\r\nÔng bà đã nói\r\nPhải biết trông rộng nhìn xa\r\nNhẹ chạm bờ môi em mượt mà như câu thở\r\nGần nhau thật lâu làm màu son lại mau mờ\r\nThả thêm vài câu em nói anh câu giờ\r\nTừ lời, từng flow người anh thi người cover\r\nAnh rap khi có phiêu, keep it real\r\nĐiều chưa có không dám nêu, không nói điêu\r\nAnh đã thiêu những quá khứ, anh có tàn tro đen\r\nTừ bùn lầy anh ngoi lên chẳng khác gì hoa sen, graaa!";
                    break;
                case "Blue Tequila":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Singer";
                    labelLyrics.Text = "Hai tequila như mọi khi trong tuần\r\nNhạc bật Frank Sinatra nhưng mà tôi không cần\r\nBuồn phiền từ đâu lao đến đây vây quanh\r\nMệt nhoài cùng tôi đang nắm tay\r\nEm ra ban công vô tình đi ngang quầy\r\nHình như em đang say sau vài ly vang đầy\r\nTình cờ đời ta va lấy nhau, không may\r\nNgười tìm được tôi nơi đáy sâu\r\nBồi hồi nhìn nhau điếu thuốc kia đang tàn\r\nNgoài đường dòng xe nối tiếp nhau vội vàng\r\nNhiều lần hợp tan nuối tiếc trong muộn màng\r\nGiờ chỉ cầu ai đó xoá đi thời gian\r\nĐừng làm trời lên khói thuốc kia thay màu\r\nĐừng làm bầu không khí chuốc thêm ưu sầu\r\nĐừng làm tình ta sẽ chết ngay ban đầu\r\nDù mập mờ không biết sẽ đi về đâu\r\nVà người nhìn bằng đôi mắt khép hờ lại bờ môi\r\nMột người làm lòng tôi muốn có một người cần tôi\r\nSau bao dối gian trong đời\r\nYêu đương hoá ra không lời, nên...\r\nNgười chìm mình vào ao ước biến cuộc tình thành phim\r\nNgười vì vài lần đau đớn bắt lòng mình lặng im\r\nRiêng tôi sẽ luôn yêu người\r\nNhư tôi đã luôn yêu người\r\nTừ đầu\r\nEm thở nhẹ một sợi khói, khiến bầu trời vỡ làm hai nửa\r\nNếu mà anh không tới, thì cả đời đâu còn ai sửa\r\nĐóm lửa đỏ trên đầu thuốc rơi vào gạt tàn như thể sao băng\r\nHồn anh như lạc đàn ở giữa bạt ngàn góc rễ bao quanh\r\nXin lỗi vì lòng hơi say\r\nTrong đầu thì đầy chếnh choáng\r\nCảm ơn những nỗi buồn vì đã đưa đôi chân này đến quán\r\nAnh biết là nếu đêm tàn sẽ kéo thêm ngàn suy nghĩ miên man\r\nNên là, vui đi, để tim mình liên hoan\r\nNgười khép đôi hàng mi không sầu vương đang nhìn tôi\r\nNgười khiến tôi nhận ra tôi chỉ yêu em mà thôi\r\nSau bao dối gian trong đời\r\nYêu đương hoá ra không lời, nên...\r\nCòn có bao người mong cho tình yêu kia thành phim\r\nVà có bao người đau nên buộc con tim lặng im\r\nRiêng tôi sẽ luôn yêu người\r\nNhư tôi vẫn luôn yêu người\r\nHai tequila như mọi khi trong tuần\r\nNhạc bật Frank Sinatra nhưng mà tôi không cần\r\nMệt nhoài từ đâu lao đến đây vây quanh\r\nBuồn phiền cùng tôi đang nắm tay\r\nEm ra ban công vô tình đi ngang quầy\r\nHình như em đang say sau vài ly vang đầy\r\nVà rồi đời ta va lấy nhau, không may\r\nNgười tìm được tôi nơi đáy sâu";
                    break;
                case "The Lazy Song":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Singer";
                    labelLyrics.Text = EN.Rows[0]["loibaihat"].ToString();
                    break;
                case "Heat Waves":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Singer";
                    labelLyrics.Text = EN.Rows[1]["loibaihat"].ToString();
                    break;
                case "Head In The Cloud":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Singer";
                    labelLyrics.Text = EN.Rows[2]["loibaihat"].ToString();
                    break;
                case "comethru":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Singer";
                    labelLyrics.Text = EN.Rows[3]["loibaihat"].ToString();
                    break;
                case "Paris in the Rain":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Singer";
                    labelLyrics.Text = EN.Rows[4]["loibaihat"].ToString();
                    break;
                case "Rude":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Band";
                    labelLyrics.Text = EN.Rows[5]["loibaihat"].ToString();
                    break;
                case "When I Grow Up":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Rapper";
                    labelLyrics.Text = EN.Rows[6]["loibaihat"].ToString();
                    break;
                case "Counting Stars":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Band";
                    labelLyrics.Text = EN.Rows[7]["loibaihat"].ToString();
                    break;
                case "death bed":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Singer";
                    labelLyrics.Text = EN.Rows[8]["loibaihat"].ToString();
                    break;
                case "Stressed out":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Band";
                    labelLyrics.Text = EN.Rows[9]["loibaihat"].ToString();
                    break;
                case "Heads Will Roll":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Producer";
                    labelLyrics.Text = EDM.Rows[0]["loibaihat"].ToString();
                    break;
                case "Waiting For Love":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Producer";
                    labelLyrics.Text = EDM.Rows[1]["loibaihat"].ToString();
                    break;
                case "If Only I Could":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Producer";
                    labelLyrics.Text = EDM.Rows[2]["loibaihat"].ToString();
                    break;
                case "Journey":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Producer";
                    labelLyrics.Text = EDM.Rows[3]["loibaihat"].ToString();
                    break;
                case "Where Are You Now":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Producer";
                    labelLyrics.Text = EDM.Rows[4]["loibaihat"].ToString();
                    break;
                case "Silence":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Producer";
                    labelLyrics.Text = EDM.Rows[5]["loibaihat"].ToString();
                    break;
                case "Leyla":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Producer";
                    labelLyrics.Text = EDM.Rows[6]["loibaihat"].ToString();
                    break;
                case "When The Sun's Gone":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Producer";
                    labelLyrics.Text = EDM.Rows[7]["loibaihat"].ToString();
                    break;
                case "Bullet Waiting For Me":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Producer";
                    labelLyrics.Text = EDM.Rows[8]["loibaihat"].ToString();
                    break;
                case "Roses":
                    labelDecorMusic.Text = labelNowPlay.Text;
                    picDecor.BackgroundImage = picNowPlay.BackgroundImage;
                    labelDecorArtist.Text = labelNowArtist.Text;
                    labelDecorArtistName.Text = "Producer";
                    labelLyrics.Text = EDM.Rows[9]["loibaihat"].ToString();
                    break;
            }
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            switch (labelNowPlay.Text)
            {
                case "#AiChoAi":
                  
                    VN.Rows[0]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[0]["binhluan"].ToString();
                    break;
                case "Không sao đâu":
                    VN.Rows[1]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[1]["binhluan"].ToString();
                    break;
                case "Sài Gòn buồn quá em ơi":
                    VN.Rows[2]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[2]["binhluan"].ToString();
                    break;
                case "Trốn tìm":
                    VN.Rows[3]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[3]["binhluan"].ToString();
                    break;
                case "Loving You Sunny":
                    VN.Rows[4]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[4]["binhluan"].ToString();
                    break;
                case "Chuyện chàng trông xe":
                    VN.Rows[5]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[5]["binhluan"].ToString();
                    break;
                case "Anh không thề gì đâu anh làm":
                    VN.Rows[6]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[6]["binhluan"].ToString();
                    break;
                case "Trên Lầu Cao":
                    VN.Rows[7]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[7]["binhluan"].ToString();
                    break;
                case "Nhập gia tùy tục":
                    VN.Rows[8]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[8]["binhluan"].ToString();
                    break;
                case "Blue Tequila":
                    VN.Rows[9]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[9]["binhluan"].ToString();
                    break;
                case "The Lazy Song":
                    EN.Rows[0]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[0]["binhluan"].ToString();
                    break;
                case "Heat Waves":
                    EN.Rows[1]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[1]["binhluan"].ToString();
                    break;
                case "Head In The Cloud":
                    EN.Rows[2]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[2]["binhluan"].ToString();
                    break;
                case "comethru":
                    EN.Rows[3]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[3]["binhluan"].ToString();
                    break;
                case "Paris in the Rain":
                    EN.Rows[4]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[4]["binhluan"].ToString();
                    break;
                case "Rude":
                    EN.Rows[5]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[5]["binhluan"].ToString();
                    break;
                case "When I Grow Up":
                    EN.Rows[6]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[6]["binhluan"].ToString();
                    break;
                case "Counting Stars":
                    EN.Rows[7]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[7]["binhluan"].ToString();
                    break;
                case "death bed":
                    EN.Rows[8]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[8]["binhluan"].ToString();
                    break;
                case "Stressed out":
                    EN.Rows[9]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[9]["binhluan"].ToString();
                    break;
                case "Heads Will Roll":
                    EDM.Rows[0]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[0]["binhluan"].ToString();
                    break;
                case "Waiting For Love":
                    EDM.Rows[1]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[1]["binhluan"].ToString();
                    break;
                case "If Only I Could":
                    EDM.Rows[2]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[2]["binhluan"].ToString();
                    break;
                case "Journey":
                    EDM.Rows[3]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[3]["binhluan"].ToString();
                    break;
                case "Where Are You Now":
                    EDM.Rows[4]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[4]["binhluan"].ToString();
                    break;
                case "Silence":
                    EDM.Rows[5]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[5]["binhluan"].ToString();
                    break;
                case "Leyla":
                    EDM.Rows[6]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[6]["binhluan"].ToString();
                    break;
                case "When The Sun's Gone":
                    EDM.Rows[7]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[7]["binhluan"].ToString();
                    break;
                case "Bullet Waiting For Me":
                    EDM.Rows[8]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[8]["binhluan"].ToString();
                    break;
                case "Roses":
                    EDM.Rows[9]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[9]["binhluan"].ToString();
                    break;
            }
        }
        int temp;
        int i = -1;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            switch (labelNowPlay.Text)
            {
                case "#AiChoAi":
                    {
                        int checklike = Convert.ToInt32(VN.Rows[0]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                VN.Rows[0]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                VN.Rows[0]["liked"] = 1;
                                Like.Rows.Add("VN", Properties.Resources.ACA, 0, "#AiChoAi", "FloD", "2:40", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN FloD -  #AiChoAi.wav", "Sớm mai tỉnh dậy tôi lạc vào hư không\r\nĐôi tay níu lấy điều gì mà chờ mong\r\nNắng kéo mây về\r\nGió kéo đông về\r\nBuồn người thương kéo tôi về ngày yêu\r\nĐêm qua mơ thấy anh quay về\r\nÔm choàng nhau ấm áp đông qua\r\nThức giấc môi cười\r\nÔi là mơ thôi\r\nBuồn tôi ơi khi nào mày vơi\r\nAnh cứ đi đi tìm tình yêu mới\r\nTôi đứng đây ôm trọn tình yêu cũ\r\nNhắn gió mây gửi đến anh đôi lời\r\nSợi tơ duyên đứt đi rồi có nối lại được không\r\nAh anh chẳng thể nắm được duyên tình mặc dù luôn muốn giữ em cho riêng mình\r\nAnh chẳng thể giữ em lại đây mặc dù cô đơn vẫn cứ luôn bủa vây\r\nAnh biết trước hai ta phải xa nhau\r\nThêm lâu rồi niềm đau sẽ thêm sâu\r\nNhưng nếu ta xa nhau thì con tim này ai khâu\r\nAnh biết thời gian rồi vẫn qua\r\nThanh xuân cả hai rồi sẽ qua\r\nNhưng có những thứ cả hai chẳng thể xoá\r\nEm tồn tại trong anh là giấc mơ\r\nAnh đã tìm được em trong nỗi nhớ\r\nNhưng anh sống với hiện thực\r\nTình yêu còn đó chẳng kết thúc như giấc mơ\r\nEm đi qua như dòng chảy của dòng sông\r\nAnh là phiên đá cũ tự hỏi em về không\r\nEm đi qua dòng nước khác vẫn quanh anh\r\nNhưng anh lại cảm thấy nỗi cô đơn vẫn bao quanh\r\nAnh chẳng thể mua được thời gian\r\nChẳng thể yêu ngày hôm qua\r\nCâu chuyện giờ đã lật sang trang\r\nKết chuyện là anh nhìn em rời xa\r\nAnh cứ đi đi tìm tình yêu mới\r\nTôi đứng đây ôm trọn tình yêu cũ\r\nNhắn gió mây gửi đến anh đôi lời\r\nSợi tơ duyên đứt đi rồi có nối lại được không\r\nTừng giây phút\r\nNgày xưa đó\r\nNgười có nhớ\r\nNhớ\r\nNhớ\r\nNhớ không");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Không sao đâu":
                    {
                        int checklike = Convert.ToInt32(VN.Rows[1]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                VN.Rows[1]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                VN.Rows[1]["liked"] = 1;
                                Like.Rows.Add("VN", Properties.Resources.KSD, 0, "Không sao đâu", "cam", "4:54", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN cam - không sao đâu.wav", "CAM:\r\nYeah, hôm nay là ngày thứ mấy ở trong tuần\r\nNhiều cần đã cháy, nhiều lần đã thấy trước được hồi kết nhưng không tuân\r\nMấy lần những cuộc gọi nhỡ và lỡ có buông lời nói mớ, \r\nCũng nhớ gì đâu khi sâu trong óc vẫn còn quá nhiều điều đáng sợ.\r\nMọi thứ dường như đang quá tầm kiểm soát.\r\nCảm giác thế giới qua mặt được em, giờ đã xa tầm liên lạc.\r\nRồi em lại check Facebook, \r\nThâm tâm lại tự trách giây phút em nể bản than mình quá nhiều, \r\nEm để bản than mình hóa liều, quá liều.\r\nĐã bao lâu nay sao em không về nhà ?\r\nCòn phải bao nhiêu đêm trôi qua để mà em thôi rề rà ?\r\nEm nghe lời khuyên và điên từ tối qua,\r\nĐâu phải mê cung nào cũng tìm được lối ra.\r\nEm hay suy tư và dư ra thời giờ,\r\nVà đôi khi em không say no, bao niềm vui ai mời hờ (okay)\r\nChi ra bao nhiêu mua giấc mơ ?\r\nChi ra bao nhiêu ?\r\n\r\nIT’S ALRIGHT,\r\nCòn bao nỗi buồn, mình đâu muốn phải giấu ai.\r\nKhông sao em à, do it, IT’S ALRIGHT.\r\nVừa khóc, vừa cười này. (I wish I cared a little bit more)\r\n\r\nGIMME YOUR SOUL AND THEN GIMME YOUR… X3\r\n\r\nSHYNASTY:\r\nLang thang, lang thang\r\nBiết bao nhiêu ngày tháng, tâm bình thản, chân lang thang.\r\nNhìn những đám mây vàng nhẹ nhàng trôi lãng đãng, nhịp nhàng, đơn giản, ta chỉ muốn được mãn nhãn.\r\nLan man, lan man\r\nĐèn vàng chạng vạng, âm thanh xung quanh vang vang.\r\nKhông gì giới hạn bạn, con tim băng như đang tan.\r\nNhững gì chung tần số, hãy tìm cách để lan sang.\r\nTôi được dạy là không được thử, dù chỉ một lần,\r\nĐặt những thứ thay đổi tâm trạng, chạm gần tới môi.\r\nTôi đã nói không với suy nghĩ này rất nhiều lần,\r\nNhưng khổ nỗi suy nghĩ này lại không nói gì với tôi.\r\nĐôi khi không nguy hiểm như là người ta nghĩ,\r\nChỉ là một chuyến đi, nhưng không mang theo vali.\r\nNhư trôi đi Paris (yeah), như trôi về Bali (yeah).\r\nChỉ là đang giải trí, không cầu kì hay xa xỉ.\r\nCó những lúc ta bị (what), khó tính là đa nghi\r\nCuốn vào sự ma mị, while I’m getting money.\r\nNhững cảm giác lạ kì, nó đến và rồi ra đi.\r\nChỉ đơn giản là vì, đó là hiệu ứng suy nghĩ.\r\n\r\nIT’S ALRIGHT,\r\nCòn bao nỗi buồn, mình đâu muốn phải giấu ai.\r\nKhông sao em à, do it, IT’S ALRIGHT.\r\nVừa khóc, vừa cười này. (I wish I cared a little bit more)\r\n\r\nGIMME YOUR SOUL AND THEN GIMME YOUR… X3");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Sài Gòn buồn quá em ơi":
                    {
                        int checklike = Convert.ToInt32(VN.Rows[2]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                VN.Rows[2]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                VN.Rows[2]["liked"] = 1;
                                Like.Rows.Add("VN", Properties.Resources.SGBQEO, 0, "Sài Gòn buồn quá em ơi", "Dế Choắt", "5:18", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Dế Choắt - Sài Gòn buồn quá em ơi.wav", "Sài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi, em ơi\r\nSài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi\r\nSài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi, em ơi\r\nSài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi\r\n\r\nAnh biết\r\nSài Gòn có những đêm buồn thức trắng\r\nLy cafe sữa vẫn còn vị ngọt nơi đầu môi\r\nAnh biết\r\nLà anh biết tất cả bộn bệ ở nơi mình từng\r\nLàm sao có thể thay đổi\r\nKhi chẳng có người đi cùng đổi thay\r\nTình đầu là tình vụn vỡ\r\nNgày mà mình chưa từng gặp gỡ\r\nNgày hôm qua quá nhiều chuyện buồn\r\nTrong từng nhịp thở\r\nCứ mãi cho đến một ngày\r\nNgày bình thường vô tình gặp nhau\r\nThì mới biết tim đã rối bời\r\nChẳng phải em thì chẳng tìm được đâu\r\nTâm hồn anh thì già cỗi\r\nChưa từng một lần rực rỗi\r\nMỗi khi thấy chân em dừng lại\r\nXin một lần hỏi\r\nNắng chói chang khắp chiều tà\r\nHoàng hôn yên vị xong rồi lại đi\r\nEm là thuyền trưởng\r\nAnh sẽ căng buồm\r\nChẳng ngại vì gió lau nhẹ bờ mi\r\nĐể cho anh một lần được nói\r\nCho anh một lần được hỏi\r\nPhải chăng anh là điểm tựa\r\nĐể em dựa mỗi ngày mệt mỏi?\r\nĐể cho anh một lần được nói\r\nCho anh một lần được hỏi\r\nNếu một ngày không gặp anh nữa\r\nEm có vội vàng đi tìm anh không?\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi lạc thì xem như mất nhau!\r\nNgười vội bước còn người đang đứng sau\r\nCần một điều ước để vượt qua nỗi đau\r\nDù phút chốc Sài Gòn vẫn vui\r\nSao anh mãi buồn?\r\nSài Gòn tháng năm sau\r\nAnh không, không còn em nữa đâu\r\nGiận rồi người cũng xa nhau\r\nQuên nhau, không còn nghĩ đến nhau\r\nNgày buồn nhất là ngày ta vỡ tan\r\nNgười ngồi khóc\r\nCòn người đang trách than\r\nNgày này tháng ấy mình rời bỏ nhau\r\nTrong đêm mưa buồn\r\n\r\nVì tình yêu đã lỡ một nhịp\r\nĐành phải nhường lại cho người đến sau\r\nKhi anh chỉ còn một nhịp\r\nAnh chỉ muốn thở hết những nỗi đau\r\nAnh không tin vào định mệnh\r\nAnh tin vào ngày mai\r\nNếu anh không thể làm được điều gì nữa\r\nThì chắc lẽ là anh sai\r\nVà em nên nhớ\r\nTình yêu không thể\r\nĐếm bằng ngày đâu em\r\nĐó là tất cả những gì đọng lại\r\nSau nhưng đêm dài buồn không tên\r\nĐến khi cảm xúc thấu được mình đã\r\nTrải qua quá nhiều lần tổn thương\r\nChiếc gương ấy sẽ xóa được hình bóng ai\r\nĐã khiến lòng mình vấn vương\r\nDù sai, dù đúng\r\nTất cả cũng không quan trọng vì\r\nNgười đi, người đến người ở lại\r\nLà vì hiểu nhau thì\r\nNgày em buồn nhất\r\nAnh sẽ đứng lại dù trời có mưa\r\nVà anh muốn hỏi tất cả chuyện buồn\r\nEm đã cất chưa\r\nBình yên là lúc ta cùng nhìn lại\r\nNở một nụ cười cho dù đớn đau\r\nBình yên là lúc có người tồn tại\r\nLuôn nằm phía sau\r\nTình yêu đẹp nhất khi lòng thù hận\r\nEm cần vứt đi\r\nTình yêu chỉ đến sau những mảnh vụn\r\nCó kẻ ghép lại, lau nhẹ ướt mi\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi lạc thì xem như mất nhau!\r\nNgười vội bước còn người đang đứng sau\r\nCần một điều ước để vượt qua nỗi đau\r\nDù phút chốc Sài Gòn vẫn vui\r\nSao anh mãi buồn?\r\nSài Gòn tháng năm sau\r\nAnh không, không còn em nữa đâu\r\nGiận rồi người cũng xa nhau\r\nQuên nhau, không còn nghĩ đến nhau\r\nNgày buồn nhất là ngày ta vỡ tan\r\nNgười ngồi khóc\r\nCòn người đang trách than\r\nNgày này tháng ấy mình rời bỏ nhau\r\nTrong đêm mưa buồn\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi, lạc thì xem như mất nhau!\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi, lạc thì xem như mất nhau!");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Trốn tìm":
                    {
                        int checklike = Convert.ToInt32(VN.Rows[3]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                VN.Rows[3]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                VN.Rows[3]["liked"] = 1;
                                Like.Rows.Add("VN", Properties.Resources.TT, 0, "Trốn Tìm", "Đen", "4:12", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Đen - Trốn Tìm.wav", "Có một cái cây trong một cái vườn\r\nTrên những tán cây nở rộ những đoá hoa\r\nCó hai đứa nhóc đang chơi trốn tìm\r\nTìm hoài tìm mãi nên quên lối về\r\nAnh đi tìm thì em trốn anh đi trốn em không tìm\r\nLòng em không gợn sóng cuối cùng anh mất công chìm\r\nNếu mà có cây búa anh sẽ nện cho bõ công\r\nVì nhớ nhung đặc quánh giờ nó khô thành bê tông\r\nChúng ta rồi sẽ có có những chuyến đi dài\r\nTa tự học lấy mọi thứ vì trong tình trường làm biếng ghi bài\r\nCâu chuyện của chúng ta bỗng có thêm một miếng bi hài\r\nVì cách mà em gọi anh không có u và thiếu y dài\r\nPhía xa thành phố người ta đã bật đèn đường\r\nHương quen xưa làm anh thấy thật thèm thuồng\r\nNỗi buồn vàng rực cứ như là chứa đồng thau\r\nHệt như là Beckham vậy em chỉ giỏi cứa lòng nhau\r\nHé cửa sổ ra mà xem\r\nCó một chàng thi sĩ đứng ở ngay nhà em\r\nViết nhạc tình mát ngọt tựa như cây cà rem\r\nAnh ta sẽ đứng ở nơi đây cả đêm\r\nCó hai cái cây trong một cái vườn (có hai cái cây trong vườn)\r\nTrên những tán cây nở rộ những đoá hoa (có những đoá hoa trên cành)\r\nCó hai đứa nhóc đang chơi trốn tìm (có hai đứa nhóc đang chơi)\r\nTìm hoài tìm mãi nên quên lối về\r\nHồi đó anh rụt rè như đám cây mắc cỡ\r\nGần em làm anh hồi hộp tới mức gây tắc thở\r\nTa đều không biết có điều gì sau đám mây sắp nở\r\nTrò chơi trốn tìm ngày đó sau này đầy trắc trở\r\nTa săn bắn những khát vọng và hái lượm những giấc mơ\r\nTa gieo trồng cây ước mộng thứ mà lấy đi nhiều thì giờ\r\nTa đào những cái hố mà không biết có ngày bị lọt\r\nĐể rất lâu sau này chúng ta cau mày nhận ra không phải tất cả bông hoa thì đều sẽ có những nhụy ngọt\r\nGọi tên em làm anh mất giọng hoài\r\nHệt như là một giấc mộng dài\r\nTa đi tìm cả thế giới nhưng mà lại trốn nhau\r\nBiết vậy thà nghỉ chơi từ lúc mới chớm đau (từ lúc mới chớm đau)\r\nNgười đi tìm cái người đi trốn\r\nNgười đi trốn cái người đi tìm\r\nTình yêu từ những ngày xưa đã\r\nNgủ quên dưới tán cây im lìm\r\nCó ba cái cây trong một cái cái vườn\r\nTrên những tán cây nở rộ những đoá hoa\r\nCó hai đứa nhóc đang chơi trốn tìm\r\nTìm hoài tìm mãi nên quên lối về\r\nAi đó đã chặt hết cây và cũng chẳng thấy vườn (chẳng thấy cây trong vườn)\r\nAi đó đã xây một ngôi nhà rất to (chặt hết cây đi rồi)\r\nChắc em hạnh phúc yên vui với người (chắc em hạnh phúc yên vui)\r\nNhà em có chó anh không dám vào\r\nNiềm cô đơn của những người trưởng thành\r\nLà khi muốn trốn nhưng không ai tìm\r\nNhiều khi ta muốn ta được bé lại\r\nĐể khi đi trốn có người đi tìm\r\nNhiều khi ta muốn ta được bé lại\r\nĐể khi đi trốn có người đi tìm");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Loving You Sunny":
                    {
                        int checklike = Convert.ToInt32(VN.Rows[4]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                VN.Rows[4]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                VN.Rows[4]["liked"] = 1;
                                Like.Rows.Add("VN", Properties.Resources.LYS, 0, "Loving You Sunny", "Kimmese", "4:56", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Kimmese - Loving You Sunny.wav", "Thoát ra mối sầu đêm nay\r\nCho em gối đầu lên tay\r\nKhông cần thuê người tư vấn\r\nYên tâm mình sẽ tự phối màu thêm hay\r\nAnh sẽ pha màu nhạt khói\r\nVào màu trầm của môi em\r\nVà nếu bên nhau là lạc lối\r\nThì mình cứ để mọi thứ kia trôi êm\r\nI wish you could give me another chance\r\nHave you ever thought of us as a future plan\r\nInside my heart, I know I don't wanna give up\r\nUntil i can have your love\r\nI know it worths it baby\r\nI know what makes me happy is you\r\nNobody could\r\nKiss me like the way you do\r\nThe way you talk to me, yeah\r\nI don't need no drugs only your love make me feel that high\r\nSunny that's why I love you\r\nOnly you can make me feel, in love again\r\nPicture me in the battle, finding you again\r\nI can feel a sunshine, in me one more time\r\nWhenever I see yo green eyes\r\nThats why I love you sunny\r\nHere's my heart just take it everywhere you go\r\nDestiny will bring me back to you for show\r\nWoah, I know you got everything i want\r\nIf you still love me\r\nGive me a chance\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h-oh-oh, Sunny\r\nYou\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h oh-oh, Sunny\r\nYou\r\nYou're amazing you're unique\r\nAnd you're bad\r\nYour lifestyle, interesting, passionate\r\nAnd I adore you\r\nBy the way you carry yourself\r\nBabe, you do it so well\r\nAnd I like that, like that\r\nI wanna show you my real world\r\nNo acting up, no playing games\r\nNo wall\r\nJust spend with me and u will see\r\nWe are meant to be\r\nCause i'm your baby\r\nOnly you can make me feel in love again\r\nPicture me in the battle, finding you again\r\nI can feel a sunshine in me one more time\r\nWhenever I see yo green eyes\r\nThats why I love you sunny\r\nHere's my heart just take it everywhere you go\r\nDestiny will bring me back to you for show\r\nWoah, I know you got everything i want\r\nIf you still love me\r\nGive me a chance\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h-oh-oh, Sunny\r\nYou\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h oh-oh, Sunny\r\nYou\r\nEm không cần mặc đẹp, vì anh thích lôi thôi\r\nGiam em bằng vòng tay rộng và\r\nTra tấn em bằng đôi môi\r\nLòng mình vui như tết á\r\nKhông cần chờ đêm ba mươi\r\nThả mình vào trong biển lớn\r\nKhông cần buồm mà ra khơi\r\nVì mình có quá nhiều ngày cô đơn nên ngày bên em dường như là không đủ\r\nMình sẽ phải cần thêm nhiều cà phê hơn\r\nVì đêm nay chúng ta sẽ không ngủ\r\nAnh sẽ vặn ngược lại kim của đồng hồ\r\nĐể nó luôn chỉ thời khắc nửa đêm\r\nTa sẽ có một ngày dài như là thế kỷ như vậy mới đủ để cho anh hiểu em\r\nNói lời chân thật với nhau, đừng bắt tâm tư phải sàng và lọc\r\nEm cần may túi ba gang vì lúc bên nhau là vàng là ngọc\r\nCó hàng tá rapper ngoài kia nhưng sẽ không có một Đen thứ hai\r\nViết cho em những điều kì lạ, em sẽ nhận ra chỉ Đen chứ ai\r\nBởi vì anh không thích đồ ngọt nên hãy yêu nhau theo cách mặn mà\r\nCứ yên tâm nhạc tình Đen viết luôn đặc quánh và rất đậm đà\r\nChắt chiu như trong một sớm trên lá đọng vệt trong ngần sương\r\nYêu em như cách anh viết nhạc, luôn cần mẫn mà không cần lương\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h-oh-oh, Sunny\r\nYou\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h oh-oh, Sunny\r\nYou");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Chuyện chàng trông xe":
                    {
                        int checklike = Convert.ToInt32(VN.Rows[5]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                VN.Rows[5]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                VN.Rows[5]["liked"] = 1;
                                Like.Rows.Add("VN", Properties.Resources.CCTX, 0, "Chuyện chàng trông xe", "MCK", "3:15", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN MCK - Chuyện chàng trông xe.wav", "một toán học sinh lại đến\r\ncầm phấn viết lên yên xe\r\n24 25 biết khi nào xong\r\n“Xe em cho thẳng vào trong nhé”\r\nVina còn chưa kịp châm\r\ntrà đá vẫn chưa kịp nhấp môi\r\nTrời sập tối mưa rào\r\n\r\ndòng xe chắp nối đưa vào\r\n\r\nvà em \r\nsố xe 07 em ra mà xem\r\n\r\nlàm anh nhớ mong cả đêm\r\n\r\nthế nhưng cái tên lại quên\r\nvà anh\r\nlàm nghề cầm phấn nhưng không ai nghe\r\nBa anh lái xe bảo học không nghe\r\nthế nên giờ đây số kiếp trông xe\r\nđừng làm anh mong nhớ\r\nsánh đôi có lẽ chỉ ở trong mơ thôi\r\nchạm mặt em xong lỡ\r\ntrái Tim vụn vỡ lại đập loạn nhịp mong chờ\r\n\r\nsinh ra ở khu lao động không đi trông xe thì cũng xách vữa\r\nphổ biến là làm lao công còn muốn nghèo có thêm chục cách nữa\r\nBố mẹ anh không đủ tiền cho anh đi học cùng bạn trang lứa\r\nCây phấn mỗi ngày anh dùng phủ cuộc đời anh trắng thêm trang nữa\r\nđồng phục, tóc búi, cười hiền đi converse và em sơ vin\r\nlướt qua là anh muốn cưới, lấy giấy tờ, bỏ vào all in ô in\r\nEm như cây bút chì màu vẽ cuộc đời anh ở khung hình riêng\r\nThơ ngay 1 chút tình đầu anh muốn xoá bỏ đi những định kiến\r\nbố mẹ vẫn bảo anh là “sao mày đũa mốc mà chòi mâm son”\r\nhọc toán còn chưa ăn ai bây h mày thích học đòi không con\r\nmuốn đưa vé xe cho em nhưng anh lại sợ làm dơ áo trắng\r\nGiọng em ngọt như kem làm cổ họng anh tự nhiên nó đắng\r\n\r\ntương tư về em mỗi đêm cùng với thăng long anh lười không ngủ\r\ntưởng như chỉ yêu mỗi em dưới ánh trăng cong chửi “người âm phủ”\r\nmấy thằng con trai miệng lưỡi dẻo quẹo thì xin em đừng cả tin\r\nngoài đời thì nó thả bả còn lên mạng thì nó thả tim\r\n1 túp lều tranh 2 trái Tim vàng thì chắc bây giờ không có\r\nNgày 2 chúng ta yêu nhau thì chắc là ngày mặt trời không ló\r\nbố mẹ em cần ví dày nhưng giống bụng anh ví anh lép kẹp\r\nnhà anh có mỗi cửa sổ nên chuyện tình mình giờ chắc khép đẹp");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Anh không thề gì đâu anh làm":
                    {
                        int checklike = Convert.ToInt32(VN.Rows[6]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                VN.Rows[6]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                VN.Rows[6]["liked"] = 1;
                                Like.Rows.Add("VN", Properties.Resources.AKTGDAL, 0, "Anh không thề gì đâu anh làm", "Phúc Du", "2:10", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN PHÚC DU - ANH KHÔNG THỀ GÌ ĐÂU ANH LÀM.wav", "Ngày tháng có em bên cạnh trôi qua như một cơn mơ nhanh\r\nAnh có phải là bắp rang đâu mà em bơ anh\r\nEm ơi, xin đừng giận anh, đừng làm khó thêm\r\nTrong tim anh em như là Hawkeye, vì em luôn có tên\r\nEm luôn đứng đầu, em luôn đứng đầu\r\nDù em như bị trúng gió, em cứng cổ và cứng đầu\r\nAnh yêu em và nhiều đêm, tương tư anh lại nhiều thêm\r\nNgười ta thích là chiều ta, còn anh thì chỉ thích chiều em\r\nBên cạnh em anh luôn là khó ngầu\r\nVì nếu tim anh là mùa xuân, em là cơn gió đầu\r\nNghĩ về em cả hàng giờ, anh không mong tim em có sầu\r\nYêu em như một bàn cờ, anh mong kết cục có hậu\r\nTa cạn say, chén rượu xuân cay nồng và ngắm cánh nhạn bay\r\nChuyện tình ta như Iphone, mở ra từ cái chạm tay\r\nAnh không muốn thấy đạn bay và tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không muốn thấy đạn bay, tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm\r\nAnh nói thật là anh ghét nhất những lần ta cãi vã\r\nKhông phải chuyển giới nhưng đôi lúc anh thấy em thái quá\r\nĐâu là lí do đấy là thứ anh còn tìm\r\nNhiều lúc không biết anh đang yêu em hay anh đang chơi dò mìn\r\nNgày mà em giận, anh thấy u ám như ngày mưa\r\nSợ tình ta sẽ phải úa tàn như là vườn hồng ngày xưa\r\nĐến với em anh ôm hi vọng còn mưu mẹo thì quên đem\r\nĐếch cần 36 kế, anh chỉ cần kế bên em\r\nThương em từ sáng tới lúc trời tối đen thui\r\nHọ gọi anh là MC nhưng anh chỉ muốn làm em vui\r\nNên dù em đã nhận lời yêu anh vẫn còn thèm cưa em\r\nEm không đẹp như siêu mẫu mà siêu mẫu họ đẹp như em\r\nTừ ngày hẹn hò em làm anh thêm thói quen\r\nGiờ anh thích ăn kem vì trong kem có em\r\nEm cứ yên tâm, anh sẽ không để tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không muốn thấy đạn bay, tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Trên Lầu Cao":
                    {
                        int checklike = Convert.ToInt32(VN.Rows[7]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                VN.Rows[7]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                VN.Rows[7]["liked"] = 1;
                                Like.Rows.Add("VN", Properties.Resources.TLC, 0, "Trên Lầu Cao", "Rhymastics", "3:56", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Rhymastic - Trên Lầu Cao.wav", "Money flows in, money flows out\r\nBeware of the fishin' round it\r\nTao đi đường riêng\r\nCho dù còn bao nhiêu là ánh mắt vẫn đang liếc đi theo rình\r\n(Haters thì sao?)\r\nHaters thì sao?\r\nHỏi thằng nào mà không biết tên tao?\r\nTao mải là tao nên chưa kịp tiếp thằng nào\r\nMuốn được biết thì xuống tít bên dưới xếp hàng mau (Lineup)\r\nLife's the peephole (Yeah)\r\nYou see what your mind wanna believe though (No lie)\r\nNên tao đâu cần đi đầu (Nope)\r\nCứ đi theo lời mách bảo trong lí trí tao (That's right)\r\nYeah, cũng có lúc tao lạc mất tiết tấu\r\nYeah, cũng có lúc nhịp tao lơi\r\nVẫn lean on xuống deep low\r\nĐể nhịp swing bám vào beat và lời\r\n(Nhịp swing bám vào beat và lời)\r\n(Nhịp swing bám vào beat và lời)\r\nYeah\r\nVà khi sang ngày mới những vương bận chỉ còn là nốt nhạc cũ rích mà thôi (move up)\r\nĐạp mạnh chân ga cho bô nhả khói\r\nĐâu ai đi lạc lối cả đời?\r\nTầm nhìn mày liệu có vươn xa tới?\r\nHay là trên lời nói đầu môi?\r\nVạn vật đổi dời\r\nTao đâu dừng chân chờ ngày tàn kia đuổi tới\r\nTao đâu ngồi than khi thời gian đang tuột trôi\r\nBao nhiêu ngổn ngang đâu cần mang theo cuộc chơi?\r\nCàng nhiều buộc trói\r\nMày có thở nổi khi càng ngày càng lên cao?\r\nKhông gian càng loãng những cám dỗ càng biến ảo\r\nVà nếu mày không biết tao\r\nChắc mày nghĩ đây chỉ là câu chuyện hão (Yeah)\r\nNhạc high as em nghe theo bao nhiêu lâu? (Low)\r\nUnderground nhưng phát ở trên tầng lầu (low)\r\nSo high I paralyzed from down below (low)\r\nUnderground getting down with top flo' (low)\r\nLà underground trên lầu cao\r\n(It's how we roll around here)\r\nUnderground trên lầu cao\r\n(It's high level now)\r\nUnderground trên lầu cao\r\n(It's how we roll around here)\r\nLà underground trên lầu cao\r\nĐời ngắn có lúc đắng có lúc say\r\nChỉ sợ là mình lắm lúc mất trắng những phút giây\r\nNhiều người chìm đắm bao nhiêu năm vẫn cứ vậy\r\nThì liệu mày còn buồm căng qua vũng lầy?\r\nHay là mày thích nghe kể khổ?\r\nThích nghe kể nghèo?\r\nThích an ủi mình chùn tay?\r\nĐể rồi rả rích điệp khúc cũ\r\n\"Vì đời lắt léo thì mới chọn đường cùng này\"\r\nĐâu cần vạch đích để biết mình đang chạy\r\nCần gì thành tích để khích mình hăng say\r\nĐời người thành bại đều do mình giằng lấy\r\nKẻ vươn xa người đứng lại đều nằm ở tầm tay\r\nVì ngày mai biết được ai sẽ bị thay mới\r\nDại gì phí hoài để tương lai trôi\r\nKiếp này được vươn vai để mày trải đời\r\nLiệu mày có lại ngồi dưới đáy than đời phai phôi?\r\nVì sẽ có kẻ chỉ nói mà không làm\r\nNgười càng đói lại càng thích phàn nàn\r\nThành công vang dội thì cần gì lan man\r\nKhi chẳng cần nhiều lời miệng đời vẫn bàn tán\r\nDù lòng mày còn vướng bận, nghiệp mày còn gian nan\r\nThì cứ lấy danh dự làm la bàn\r\nChỉ cần nhớ được rằng, đêm tối dù hoạn nạn\r\nĐừng quay lưng khi mày tỏa sáng\r\nNên sân khấu này bật xuyên đêm\r\nNơi tao đứng Spaceboys luôn thức\r\nTúc trực cho những người anh em\r\nMượn lời bằng nhạc dắt nhau tới tận cùng\r\nAi cũng có thể được mời đến\r\nNhưng bản lĩnh mới được ngồi bàn trong\r\nVì tiền ở đây tha hồ đếm, khi có trình độ đúc từ vàng ròng\r\nNhạc high as em nghe theo bao nhiêu lâu? (Bao nhiêu lâu?)\r\nUnderground nhưng phát ở trên tầng lầu (Trên tầng lầu)\r\nSo high I paralyzed from down below (Chears to all my brothers and sisters)\r\nUnderground getting down with top flo'\r\nGet down!\r\nUnderground trên lầu cao\r\n(It's how we roll around here)\r\nUnderground trên lầu cao\r\n(It's high level now)\r\nUnderground trên lầu cao\r\n(It's how we roll around here)\r\nLà underground trên lầu cao");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Nhập gia tùy tục":
                    {
                        int checklike = Convert.ToInt32(VN.Rows[8]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                VN.Rows[8]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                VN.Rows[8]["liked"] = 1;
                                Like.Rows.Add("VN", Properties.Resources.NGTT, 0, "Nhập gia tùy tục", "Sol7", "3:56", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Sol7 - Nhập Gia Tuỳ Tục.wav", "You know me\r\nYou know me, yeah\r\nNgồi lên ngựa sắt\r\nLái qua phố riêng mình ta\r\nTrên chiến trường\r\nNhưng đang hát tình ca\r\nNgười đánh giá ta\r\nQua vài tấm hình mà\r\nÔng bà đã nói\r\nPhải biết trông rộng nhìn xa\r\nLập chiến tích không gây chiến tranh\r\nHoàn thành rồi anh em mình biến nhanh\r\nNhập gia thì tùy tục\r\nAnh hiền, ừ cũng tùy lúc\r\nMái đầu 7/3 cầm cây guitar rồi gảy ra\r\nĐứng yên như cột cờ nhưng ai ai cũng thấy ta\r\nKhông phải vận động viên nhưng mùa này anh nhảy xa\r\nÁp lực nặng như đá, ta là nước cứ chảy qua\r\nSăn tiền thưởng như cao bồi, uh\r\nAnh em đều có phần đam mê được trau dồi\r\nChẳng cần bước lên cao ngồi\r\nNói anh thất bại giờ mấy đứa nó sao rồi\r\nOn top ở trên tuần báo\r\nLấy tên tuổi cho thằng em bán quần áo\r\nLàm cho cả băng DCOD giá trị gia tăng\r\nỞ trong khu có người tự hào, thằng đó là bạn mình\r\nCòn nụ cười khinh thì anh coi như nó đang tàng hình\r\nFly Team, bay một đàn như loài chim\r\nĐể lại dấu ấn trên da như ngòi kim\r\nTừ đời thiệt ra lời viết\r\nHiên ngang giữa mọi thời tiết\r\nDòng đời và âm nhạc\r\nMuốn anh phải liều lĩnh\r\nThời gian là tiền bạc anh cần phải điều chỉnh\r\nNgồi lên ngựa sắt\r\nLái qua phố riêng mình ta\r\nTrên chiến trường\r\nNhưng đang hát tình ca\r\nNgười đánh giá ta\r\nQua vài tấm hình mà\r\nÔng bà đã nói\r\nPhải biết trông rộng nhìn xa\r\nMình tiến lên trong cuộc chơi mọi thứ an bài\r\nTui làm nhạc ông mê đá banh anh em ngang tài\r\nMàu cờ anh đưa lên thang dài\r\nĐón em anh đem vào trang đài\r\nBuổi sáng đang soi mái đầu anh chải\r\nChiều em mặc đồ bơi bên biển xanh mãi\r\nTối đi nghe nhạc để sầu nhanh giải\r\nBỏ ngoài tai trên mạng còn nhiều tranh cãi\r\nVẫn chờ người về đây ta cùng bay đến tương lai\r\nSợ gì vài cây, ngựa hay phải chạy đường dài\r\nNhư Cowboy viễn Tây đôi tay nhanh hơn chướng ngại\r\nKhông cần sắt đá ta vẫn xây nên tượng đài\r\nYou know I'm keeping my weapon like a soldier\r\nGiữa chặng đường dừng lại hét lên thử thách anh đâu sợ\r\nChẳng hề độc bước gia đình anh em ở sau chờ\r\nMỗi lần buồn phiền hãy ngước lên gọi Hallelujah\r\nTrôi dạt mênh mông như mây ở trên không\r\nGiọng anh trầm, yeah anh không cần lên tone\r\nGiọng anh trầm, yeah anh không cần lên tone\r\nAnh không cần lên tone\r\nNgồi lên ngựa sắt\r\nLái qua phố riêng mình ta\r\nTrên chiến trường\r\nNhưng đang hát tình ca\r\nNgười đánh giá ta\r\nQua vài tấm hình mà\r\nÔng bà đã nói\r\nPhải biết trông rộng nhìn xa\r\nNhẹ chạm bờ môi em mượt mà như câu thở\r\nGần nhau thật lâu làm màu son lại mau mờ\r\nThả thêm vài câu em nói anh câu giờ\r\nTừ lời, từng flow người anh thi người cover\r\nAnh rap khi có phiêu, keep it real\r\nĐiều chưa có không dám nêu, không nói điêu\r\nAnh đã thiêu những quá khứ, anh có tàn tro đen\r\nTừ bùn lầy anh ngoi lên chẳng khác gì hoa sen, graaa!");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Blue Tequila":
                    {
                        int checklike = Convert.ToInt32(VN.Rows[9]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                VN.Rows[9]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                VN.Rows[9]["liked"] = 1;
                                Like.Rows.Add("VN", Properties.Resources.BT, 0, "Blue Tequila", "Táo", "4:21", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Táo - Blue Tequila.wav", "Hai tequila như mọi khi trong tuần\r\nNhạc bật Frank Sinatra nhưng mà tôi không cần\r\nBuồn phiền từ đâu lao đến đây vây quanh\r\nMệt nhoài cùng tôi đang nắm tay\r\nEm ra ban công vô tình đi ngang quầy\r\nHình như em đang say sau vài ly vang đầy\r\nTình cờ đời ta va lấy nhau, không may\r\nNgười tìm được tôi nơi đáy sâu\r\n\r\nBồi hồi nhìn nhau điếu thuốc kia đang tàn\r\nNgoài đường dòng xe nối tiếp nhau vội vàng\r\nNhiều lần hợp tan nuối tiếc trong muộn màng\r\nChỉ cần một ai xoá hết đi thời gian\r\nĐừng làm trời lên khói thuốc kia thay màu\r\nĐừng làm bầu không khí chuốc thêm ưu sầu\r\nĐừng làm tình ta sẽ chết ngay ban đầu\r\nDù mập mờ không biết sẽ đi về đâu.\r\n\r\nVà người nhìn bằng đôi mắt khép hờ lại bờ môi\r\nMột người làm lòng tôi muốn có một người cần tôi\r\nSau bao dối gian trong đời\r\nYêu đương hoá ra không lời, nên...\r\nNgười chìm mình vào ao ước biến cuộc tình thành phim\r\nNgười vì vài lần đau đớn bắt lòng mình lặng im\r\nRiêng tôi sẽ luôn yêu người\r\nNhư tôi đã luôn yêu người\r\nTừ đầu.\r\n\r\nEm thở nhẹ một sợi khói, khiến bầu trời vỡ làm hai nửa\r\nNếu mà anh không tới, thì cả đời đâu còn ai sửa\r\nĐóm lửa đỏ trên đầu thuốc rơi vào gạt tàn như thể sao băng\r\nHồn anh như lạc đàn ở giữa bạt ngàn góc rễ bao quanh\r\nXin lỗi vì lòng hơi say, trong đầu thì đầy chếnh choáng\r\nCảm ơn những nỗi buồn vì đã đưa đôi chân này đến quán\r\nAnh biết là nếu đêm tàn sẽ kéo thêm ngàn suy nghĩ miên man\r\nNên là, vui đi, để tim mình liên hoang\r\n\r\nNgười khép đôi hàng mi không sầu vương đang nhìn tôi\r\nNgười khiến tôi nhận ra tôi chỉ yêu em mà thôi\r\nSau bao dối gian trong đời\r\nYêu đương hoá ra không lời nên\r\nCòn có bao người mong cho tình yêu kia thành phim\r\nVà có bao người đau nên buộc con tim lặng im\r\nRiêng tôi sẽ luôn yêu người\r\nNhư tôi đã luôn yêu người\r\nTừ đầu...");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "The Lazy Song":
                    {
                        int checklike = Convert.ToInt32(EN.Rows[0]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EN.Rows[0]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EN.Rows[0]["liked"] = 1;
                                Like.Rows.Add("EN", Properties.Resources.The_Lazy_Song, 0, "The Lazy Song", "Bruno Mars", "3:28", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Bruno Mars - The Lazy Song.wav", "Today I don't feel like doing anything\r\nI just wanna lay in my bed\r\nDon't feel like picking up my phone\r\nSo leave a message at the tone\r\n'Cause today I swear I'm not doing anything\r\nUh, I'm gonna kick my feet up then stare at the fan\r\nTurn the TV on, throw my hand in my pants\r\nNobody's gon' tell me I can't, nah\r\nI'll be lounging on the couch, just chilling in my Snuggie\r\nClick to MTV so they can teach me how to dougie\r\n'Cause in my castle I'm the freaking man\r\nOh, yes, I said it, I said it, I said it 'cause I can\r\nToday I don't feel like doing anything\r\nI just wanna lay in my bed\r\nDon't feel like picking up my phone\r\nSo leave a message at the tone\r\n'Cause today I swear I'm not doing anything\r\nNothing at all\r\nWoo-ooh, woo-ooh, ooh\r\nNothing at all\r\nWoo-ooh, woo-ooh, ooh\r\nTomorrow I'll wake up, do some P90X\r\nMeet a really nice girl, have some really nice sex\r\nAnd she's gonna scream out, \"This is great\" (oh, my God, this is great), yeah\r\nI might mess around and get my college degree\r\nI bet my old man will be so proud of me\r\nBut sorry pops, you'll just have to wait\r\nOh, yes, I said it, I said it, I said it 'cause I can\r\nToday I don't feel like doing anything\r\nI just wanna lay in my bed\r\nDon't feel like picking up my phone\r\nSo leave a message at the tone\r\n'Cause today I swear I'm not doing anything\r\nNo, I ain't gonna comb my hair\r\n'Cause I ain't going anywhere\r\nNo, no, no, no, no, no, no, no, no, oh\r\nI'll just strut in my birthday suit\r\nAnd let everything hang loose\r\nYeah, yeah, yeah, yeah, yeah, yeah, yeah, yeah, yeah, yeah\r\nOh, today I don't feel like doing anything\r\nI just wanna lay in my bed\r\nDon't feel like picking up my phone\r\nSo leave a message at the tone\r\n'Cause today I swear I'm not doing anything\r\nNothing at all\r\nWoo-ooh, woo-ooh, ooh\r\nNothing at all\r\nWoo-ooh, woo-ooh, ooh\r\nNothing at all");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Heat Waves":
                    {
                        int checklike = Convert.ToInt32(EN.Rows[1]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EN.Rows[1]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EN.Rows[1]["liked"] = 1;
                                Like.Rows.Add("EN", Properties.Resources.Heat_Waves, 0, "Heat Waves", "Glass Animals", "3:55", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Glass Animals - Heat Waves.wav", "Road shimmer\r\nWiggling the vision\r\nHeat heat waves\r\nI'm swimming in a mirror\r\nRoad shimmer\r\nWiggling the vision\r\nHeat heat waves\r\nI'm swimming in a\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nUsually I put\r\nSomething on TV\r\nSo we never think\r\nAbout you and me\r\nBut today I see\r\nOur reflections\r\nClearly in Hollywood\r\nLaying on the screen\r\nYou just need a better life than this\r\nYou need something I can never give\r\nFake water all across the road\r\nIt's gone now, the night has come, but\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nYou can't fight it\r\nYou can't breathe\r\nYou say something so loving, but\r\nNow I've got to let you go\r\nYou'll be better off in someone new\r\nI don't wanna be alone\r\nYou know it hurts me too\r\nYou look so broken when you cry\r\nOne more and then I'll say goodbye\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nI just wonder what you're dreaming of\r\nWhen you sleep and smile so comfortable\r\nI just wish that I could give you that\r\nThat look that's perfectly un-sad\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nHeat waves been faking me out\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nRoad shimmer\r\nWiggling the vision\r\nHeat heat waves\r\nI'm swimming in a mirror\r\nRoad shimmer\r\nWiggling the vision\r\nHeat heat waves\r\nI'm swimming in a mirror");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Head In The Cloud":
                    {
                        int checklike = Convert.ToInt32(EN.Rows[2]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EN.Rows[2]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EN.Rows[2]["liked"] = 1;
                                Like.Rows.Add("EN", Properties.Resources.Head_In_The_Cloud, 0, "Head In The Cloud", "Hayd", "3:07", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Hayd - Head In The Clouds.wav", "I miss the days when life was so simple\r\nFelt like the glass was always half full\r\nWhere did that go?\r\nAnd every second with you was so special\r\nBack when we didn't fear the unknowns\r\nBut that was long ago\r\nWho can say where the path will go?\r\nPhilosophers guess but they just don't know\r\nMaybe that's why\r\nWe had our head in the clouds\r\nThought we had it all figured out\r\nPlanning to fly away\r\nTo escape everything on the ground\r\nBut like a plane up in space\r\nWe slowly drifted away\r\nAnd every plan that we made\r\nAnd dream that we chased\r\nAre just memories now\r\nThey're just memories now\r\nI'm not sure where everything went wrong\r\nBut I know that we landed where we both belong\r\n(Where we both belong)\r\nI just wish we weren't scared to say\r\nThat there's expiration dates on the friends you make\r\nAs hard as that may sound\r\nWho can say where the path will go?\r\nPhilosophers guess but they just don't know\r\nMaybe that's why\r\nWe had our head in the clouds\r\nThought we had it all figured out\r\nPlanning to fly away\r\nTo escape everything on the ground\r\nBut like a plane up in space\r\nWe slowly drifted away\r\nAnd every plan that we made\r\nAnd dream that we chased\r\nAre just memories now\r\nThey're just memories now\r\nWho can say where the path will go?\r\n(Where the path will go? Where the path will go?)\r\nPhilosophers guess but they just don't know\r\n(But they just don't know)\r\n");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "comethru":
                    {
                        int checklike = Convert.ToInt32(EN.Rows[3]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EN.Rows[3]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EN.Rows[3]["liked"] = 1;
                                Like.Rows.Add("EN", Properties.Resources.Comethru, 0, "comethru", "Jeremy Zucker", "3:00", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Jeremy Zucker - comethru.wav", "I might lose my mind\r\nWaking when the sun's down\r\nRiding all these highs\r\nWaiting for the comedown\r\nWalk these streets with me\r\nI'm doing decently\r\nJust glad that I can breathe, yeah\r\nI'm trying to realize\r\nIt's alright to not be fine on your own\r\nNow I'm shaking, drinking all this coffee\r\nThese last few weeks have been exhausting\r\nI'm lost in my imagination\r\nAnd there's one thing that I need from you\r\nCan you come through, through?\r\nThrough, yeah\r\nAnd there's one thing that I need from you\r\nCan you come through?\r\nAin't got much to do\r\nToo old for my hometown\r\nWent to bed at noon\r\nCouldn't put my phone down\r\nScrolling patiently\r\nIt's all the same to me\r\nJust faces on a screen, yeah\r\nI'm trying to realize\r\nIt's alright to not be fine on your own\r\nNow I'm shaking, drinking all this coffee\r\nThese last few weeks have been exhausting\r\nI'm lost in my imagination\r\nAnd there's one thing that I need from you\r\nCan you come through, through?\r\nThrough, yeah\r\nAnd there's one thing that I need from you\r\nCan you come\r\nThrough, through\r\nThrough, yeah\r\nAnd there's one thing that I need from you\r\nCan you come through?");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Paris in the Rain":
                    {
                        int checklike = Convert.ToInt32(EN.Rows[4]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EN.Rows[4]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EN.Rows[4]["liked"] = 1;
                                Like.Rows.Add("EN", Properties.Resources.Paris_In_The_Rain, 0, "Paris in the Rain", "Lauv", "3:36", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Lauv - Paris in the Rain.wav", "All I know is (ooh ooh ooh)\r\nWe could go anywhere, we could do\r\nAnything, girl, whatever the mood we're in\r\nYeah all I know is (ooh ooh ooh)\r\nGetting lost late at night, under stars\r\nFinding love standing right where we are, your lips\r\nThey pull me in the moment\r\nYou and I alone and\r\nPeople may be watching, I don't mind\r\n'Cause anywhere with you feels right\r\nAnywhere with you feels like\r\nParis in the rain\r\nParis in the rain\r\nWe don't need a fancy town\r\nOr bottles that we can't pronounce\r\n'Cause anywhere, babe\r\nIs like Paris in the rain\r\nWhen I'm with you ooh ooh ooh\r\nWhen I'm with you ooh ooh ooh\r\nParis in the rain\r\nParis in the rain\r\nI look at you now and I want this forever\r\nI might not deserve it but there's nothing better\r\nDon't know how I ever did it all without you\r\nMy heart is about to, about to jump out of my chest\r\nFeelings they come and they go, that they do\r\nFeelings they come and they go, not with you\r\nThe late nights\r\nAnd the street lights\r\nAnd the people\r\nLook at me girl\r\nAnd the whole world could stop\r\nAnywhere with you feels right\r\nAnywhere with you feels like\r\nParis in the rain\r\nParis in the rain\r\nWe don't need a fancy town\r\nOr bottles that we can't pronounce\r\n'Cause anywhere, babe\r\nIs like Paris in the rain\r\nWhen I'm with you ooh ooh\r\nWhen I'm with you ooh ooh\r\nParis in the rain\r\nParis in the rain\r\nOh\r\nGirl, when I'm not with you\r\nAll I do is miss you\r\nSo come and set the mood right\r\nUnderneath the moonlight\r\n(Days in Paris\r\nNights in Paris)\r\nPaint you with my eyes closed\r\nWonder where the time goes\r\n(Yeah, isn't it obvious?\r\nIsn't it obvious?)\r\nSo come and set the mood right\r\nUnderneath the moonlight\r\n'Cause anywhere with you feels right\r\nAnywhere with you feels like\r\nParis in the rain\r\nParis in the rain\r\nWalking down an empty street\r\nPuddles underneath our feet");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Rude":
                    {
                        int checklike = Convert.ToInt32(EN.Rows[5]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EN.Rows[5]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EN.Rows[5]["liked"] = 1;
                                Like.Rows.Add("EN", Properties.Resources.Rude, 0, "Rude", "MAGIC!", "3:45", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG MAGIC - Rude.wav", "Saturday mornin', jumped out of bed\r\nAnd put on my best suit\r\nGot in my car and raced like a jet\r\nAll the way to you\r\nKnocked on your door with heart in my hand\r\nTo ask you a question\r\n'Cause I know that you're an old fashioned man\r\nYeah (yeah)\r\nCan I have your daughter for the rest of my life?\r\nSay yes, say yes, 'cause I need to know\r\nYou say I'll never get your blessin' 'til the day I die\r\n\"Tough luck, my friend, but the answer is no\"\r\nWhy you gotta be so rude?\r\nDon't you know I'm human too?\r\nWhy you gotta be so rude?\r\nI'm gonna marry her anyway\r\n(Marry that girl) marry her anyway\r\n(Marry that girl) yeah, no matter what you say\r\n(Marry that girl) and we'll be a family\r\nWhy you gotta be so rude?\r\nI hate to do this, you leave no choice\r\nCan't live without her\r\nLove me or hate me, we will be both\r\nStandin' at that alter\r\nOr we will run away\r\nTo another galaxy, you know\r\nYou know she's in love with me\r\nShe will go anywhere I go\r\nCan I have your daughter for the rest of my life?\r\nSay yes, say yes, 'cause I need to know\r\nYou say I'll never get your blessin' 'tll the day I die\r\n\"Tough luck, my friend, 'cause the answer's still no\"\r\nWhy you gotta be so rude?\r\nDon't you know I'm human too?\r\nWhy you gotta be so rude?\r\nI'm gonna marry her anyway\r\n(Marry that girl) marry her anyway\r\n(Marry that girl) no matter what you say\r\n(Marry that girl) and we'll be a family\r\nWhy you gotta be so rude?\r\nRude\r\nCan I have your daughter for the rest of my life?\r\nSay yes, say yes, 'cause I need to know\r\nYou say I'll never get your blessin' 'til the day I die\r\n\"Tough luck, my friend, but no still means no\"\r\nWhy you gotta be so rude?\r\nDon't you know I'm human too?\r\nWhy you gotta be so rude?\r\nI'm gonna marry her anyway\r\n(Marry that girl) marry her anyway\r\n(Marry that girl) no matter what you say\r\n(Marry that girl) and we'll be a family\r\nWhy you gotta be so rude?\r\nOh, yeah, oh\r\nWhy you gotta be so rude?\r\nWhy? (Yeah)\r\nWhy you gotta be so rude?");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "When I Grow Up":
                    {
                        int checklike = Convert.ToInt32(EN.Rows[6]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EN.Rows[6]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EN.Rows[6]["liked"] = 1;
                                Like.Rows.Add("EN", Properties.Resources.When_I_Grow_Up, 0, "When I Grow Up", "NF", "4:00", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG NF - When I Grow Up.wav", "[Verse 1]\r\nYeah, when I grow up, you know what I wanna be?\r\nTake a seat, let me tell you my ridiculous dreams\r\nI wanna rap, yeah, I know it's hard to believe\r\nAnd I can tell you're already thinkin' I will never succeed\r\nBut I'm okay with it, I admit the lyrics are weak\r\nI've been workin' on 'em, I'll be good eventually\r\nI understand you gotta crawl before you get to your feet\r\nBut I been running for a while, they ain't ready for me, ahh\r\nI know this prolly isn't really realistic\r\nAnd honestly, I might not ever make a difference\r\nBut that don't make a difference, I'ma have to risk it\r\nI've been crunchin' numbers, you ain't gotta be a mathematician\r\nTo see the odds ain't rootin' for me\r\nI can't lie though, it's kinda how I like it to be\r\nThe underdog, yeah, you prolly think you know what I mean\r\nBut what I'm saying is they ever push me, I'm gonna swing, yeah\r\nI could go to college, get in debt like everybody else\r\nGraduate and prolly get a job that doesn't pay the bills\r\nThat don't make a lot of sense to me, forget the Happy Meals\r\nI don't like the dollar menu, I would rather make a meal\r\nHuh? Make a mil'? Nah, I said make a meal\r\nHome-cookin', get the grill, how you want it? Pretty well?\r\nEverything I see is overdone to me, I'm not Adele\r\nBut I'ma get a record deal and say hello to mass appeal\r\nYou might also like\r\nThe Search\r\nNF\r\nLie\r\nNF\r\nTime\r\nNF\r\n[Chorus]\r\nWhen I grow up, I just want to pay my bills\r\nRappin' about the way I feel (Oh, yeah)\r\nI just want to make a couple mil'\r\nLeave it to the fam in the will (Oh, yeah)\r\nI just want to sign a record deal\r\nMaybe buy a house up in the hills (Oh, yeah)\r\nMight not be the best in my field\r\nBut I guarantee that I'ma die real\r\nWhen I grow up\r\n\r\n[Post-Chorus]\r\nYeah, ayy\r\nWhen I grow up\r\nYeah, yeah, ayy\r\n\r\n[Verse 2]\r\nI'ma make 'em notice me, rhymin' like it's poetry\r\nEverything I oversee, I just like to overthink\r\nMockin' me, you pay the fee, no return and no receipts\r\nThose of you that don't believe, quiet, you don't know a thing\r\nQuiet when I'm tryna sing, quiet when I'm making beats\r\nQuiet when I'm tryna think, sorry, I don't mean to scream\r\nI just feel like no one really gets me and it's sad to see\r\n'Cause someday I'ma grow up and show all of you it's meant to be (Yeah)\r\nAnybody wanna hear me rap? \"No\"\r\nCome on, let me play a couple tracks, \"No\"\r\nCome on, I can spit it really fast, \"No\"\r\nYou think I should throw this in the trash? \"No\"\r\nTricked ya; haters, go away before I hit ya\r\nI am not a beggar or a kiss-up\r\nYou don't understand? Well, I forgive ya\r\nI am not a quitter, you ain't really think that, did ya?\r\nMaybe someday I could even be up on the radio\r\nHave a tour bus and maybe even play a couple shows\r\nEverybody in the crowd singing every word I wrote\r\nTellin' me that I am not the only one that feels alone\r\nHuh? You feel alone? Yeah, I kinda feel alone\r\nWonder if that feelin' ever goes away when you get old\r\nWill I ever make it as an artist? I don't really know\r\nMight not make a lot of dough\r\nI'ma have to try it, though\r\n[Chorus]\r\nWhen I grow up\r\nI just wanna pay my bills\r\nRappin' about the way I feel (Oh, yeah)\r\nI just wanna make a couple mil'\r\nLeave it to the fam in the will (Oh, yeah)\r\n(Leave it to the fam in the will)\r\n(Yeah, yeah, yeah, yeah)\r\nI just wanna sign a record deal\r\nMaybe buy a house up in the hills (Okay, oh, yeah)\r\nMight not be the best in my field (Ayy, ayy, yeah)\r\nBut I guarantee that I'ma die real\r\nWhen I grow up\r\nI just wanna pay my bills (Woo)\r\nRappin' about the way I feel (Oh, yeah)\r\n(Yeah, the way I feel)\r\nYeah, I just wanna make a couple mil' (Ayy, couple mil')\r\nLeave it to the fam in the will (Oh, yeah, to the fam in the will)\r\nI just wanna sign a record deal (Woo)\r\nMaybe buy a house up in the hills (Oh, yeah)\r\n(House up in the hills)\r\nYeah, I might not be the best in my field\r\nBut I guarantee that I'ma die real\r\nWhen I grow up\r\nWhen I grow up");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Counting Stars":
                    {
                        int checklike = Convert.ToInt32(EN.Rows[7]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EN.Rows[7]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EN.Rows[7]["liked"] = 1;
                                Like.Rows.Add("EN", Properties.Resources.Counting_Stars, 0, "Counting Stars", "OneRepublic", "4:43", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG OneRepublic - Counting Stars.wav", "Lately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be counting stars\"\r\nYeah, we'll be counting stars\r\nI see this life, like a swinging vine\r\nSwing my heart across the line\r\nAnd in my face is flashing signs\r\nSeek it out and ye shall find\r\nOld, but I'm not that old\r\nYoung, but I'm not that bold\r\nAnd I don't think the world is sold\r\nOn just doing what we're told\r\nI feel something so right\r\nDoing the wrong thing\r\nAnd I feel something so wrong\r\nDoing the right thing\r\nI couldn't lie, couldn't lie, couldn't lie\r\nEverything that kills me makes me feel alive\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be counting stars\"\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be, we'll be counting stars\"\r\nYeah, yeah\r\nI feel your love, and I feel it burn\r\nDown this river, every turn\r\nHope is our four-letter word\r\nMake that money, watch it burn\r\nOld, but I'm not that old\r\nYoung, but I'm not that bold\r\nAnd I don't think the world is sold\r\nOn just doing what we're told\r\nAnd I feel something so wrong\r\nDoing the right thing\r\nI couldn't lie, couldn't lie, couldn't lie\r\nEverything that drowns me makes me wanna fly\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be counting stars\"\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be, we'll be counting stars\"\r\nOh, take that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nEverything that kills me makes me feel alive\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be counting stars\"\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be, we'll be counting stars\"\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "death bed":
                    {
                        int checklike = Convert.ToInt32(EN.Rows[8]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EN.Rows[8]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EN.Rows[8]["liked"] = 1;
                                Like.Rows.Add("EN", Properties.Resources.Deathbed, 0, "death bed", "Powfu", "2:53", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Powfu - death bed.wav", "Don't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed\r\nYeah, I don't wanna fall asleep, I don't wanna pass away\r\nI been thinking of our future, 'cause I'll never see those days\r\nI don't know why this has happened, but I probably deserve it\r\nI tried to do my best, but you know that I'm not perfect\r\nI been praying for forgiveness, you've been praying for my health\r\nWhen I leave this Earth, hoping you'll find someone else\r\n'Cause, yeah, we still young, there's so much we haven't done\r\nGetting married, start a family, watch your husband with his son\r\nI wish it could be me, but I won't make it out this bed\r\nI hope I go to Heaven, so I see you once again\r\nMy life was kinda short, but I got so many blessings\r\nHappy you were mine, it sucks that it's all ending\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed (yeah, ayy, ayy)\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed (ayy, yeah)\r\nI'm happy that you here with me, I'm sorry if I tear up\r\nWhen me and you were younger, you would always make me cheer up\r\nTaking goofy videos and walking through the park\r\nYou would jump into my arms every time you heard a bark\r\nCuddle in your sheets, sing me sound asleep\r\nAnd sneak out through your kitchen at exactly 1:03\r\nSundays, went to church, on Mondays, watched a movie\r\nSoon you'll be alone, sorry that you have to lose me\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Stressed out":
                    {
                        int checklike = Convert.ToInt32(EN.Rows[9]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EN.Rows[9]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EN.Rows[9]["liked"] = 1;
                                Like.Rows.Add("EN", Properties.Resources.Stressed_Out, 0, "Stressed out", "twenty one pilot", "3:45", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG twenty one pilots - Stressed Out.wav", "I wish I found some better sounds no one's ever heard\r\nI wish I had a better voice that sang some better words\r\nI wish I found some chords in an order that is new\r\nI wish I didn't have to rhyme every time I sang\r\nI was told when I get older, all my fears would shrink\r\nBut now I'm insecure, and I care what people think\r\nMy name's Blurryface and I care what you think\r\nMy name's Blurryface and I care what you think\r\nWish we could turn back time\r\nTo the good old days\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out (oh)\r\nWish we could turn back time (oh)\r\nTo the good old days (oh)\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out\r\nWe're stressed out\r\nSometimes a certain smell will take me back to when I was young\r\nHow come I'm never able to identify where it's coming from?\r\nI'd make a candle out of it if I ever found it\r\nTry to sell it, never sell out of it, I'd probably only sell one\r\nIt'd be to my brother, 'cause we have the same nose\r\nSame clothes, homegrown, a stone's throw from a creek we used to roam\r\nBut it would remind us of when nothing really mattered\r\nOut of student loans and tree house homes, we all would take the latter\r\nMy name's Blurryface and I care what you think\r\nMy name's Blurryface and I care what you think\r\nWish we could turn back time\r\nTo the good old days\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out (oh)\r\nWish we could turn back time (oh)\r\nTo the good old days (oh)\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out\r\nUsed to play pretend, give each other different names\r\nWe would build a rocket ship and then we'd fly it far away\r\nUsed to dream of outer space, but now they're laughing at our face saying\r\n\"Wake up, you need to make money\", yeah\r\nWe used to play pretend, give each other different names\r\nWe would build a rocket ship and then we'd fly it far away\r\nUsed to dream of outer space, but now they're laughing at our face saying\r\n\"Wake up, you need to make money\", yeah\r\nWish we could turn back time\r\nTo the good old days\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out (oh)\r\nWish we could turn back time (oh)\r\nTo the good old days (oh)\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out\r\nWe used to play pretend, used to play pretend, money\r\nWe used to play pretend, wake up, you need the money\r\nUsed to play pretend, used to play pretend, money\r\nWe used to play pretend, wake up, you need the money\r\nUsed to play pretend, give each other different names\r\nWe would build a rocket ship and then we'd fly it far away\r\nUsed to dream of outer space, but now they're laughing at our face saying\r\n\"Wake up, you need to make money\", yeah");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Heads Will Roll":
                    {
                        int checklike = Convert.ToInt32(EDM.Rows[0]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EDM.Rows[0]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EDM.Rows[0]["liked"] = 1;
                                Like.Rows.Add("EDM", Properties.Resources.Heads_Will_Roll, 0, "Heads Will Roll", "Amfree & Ampris", "2:20", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Amfree & Ampris - Heads Will Roll.wav", "Off with your head\r\nDance til you're dead\r\nHeads will roll\r\nHeads will roll\r\nHeads will roll\r\nOn the floor\r\nGlitter on the wet streets\r\nSilver over everything\r\nThe river's all wet\r\nYou're all chrome\r\nDripping with alchemy\r\nShiver stop shivering\r\nThe glitter's all wet\r\nYou're all chrome\r\nThe men cry out the girls cry out\r\nThe men cry out the girls cry out\r\nThe men cry out, oh no\r\nThe men cry out the girls cry out\r\nThe men cry out the girls cry out\r\nThe men cry out, oh no\r\nOh oh! Oh!\r\nOh oh! Oh!\r\nOff, off with your head\r\nDance, dance til you're dead (dead)\r\nHeads will roll\r\nHeads will roll\r\nHeads will roll\r\nOn the floor\r\nLooking glass\r\nTake the past\r\nShut your eyes\r\nRealize\r\nLooking glass\r\nTake the past\r\nShut your eyes\r\nRealize\r\nGlitter on the wet streets\r\nSilver over everything\r\nThe river's all wet\r\nYou're all chrome\r\nYou're all chrome\r\nOh!\r\nOh oh!\r\nOff, off, off with your head\r\nDance, dance dance til you're dead\r\nOff, off, off with your head\r\nDance, dance, dance til you're dead\r\nOff, off, off with your head\r\nDance, dance, dance til you're dead\r\nOff, off, off with your head\r\nDance, dance, dance til you're dead\r\nOff, off, off with your head\r\nDance, dance, dance til you're dead\r\nOff, off, off with your head\r\nDance, dance, dance til you're dead");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Waiting For Love":
                    {
                        int checklike = Convert.ToInt32(EDM.Rows[1]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EDM.Rows[1]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EDM.Rows[1]["liked"] = 1;
                                Like.Rows.Add("EDM", Properties.Resources.Waiting_For_Love, 0, "Waiting For Love", "Avicii", "3:50", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Avicii - Waiting For Love.wav", "Where there's a will, there's a way, kind of beautiful\r\nAnd every night has its day, so magical\r\nAnd if there's love in this life, there's no obstacle\r\nThat can't be defeated\r\nFor every tyrant, a tear for the vulnerable\r\nIn every lost soul, the bones of a miracle\r\nFor every dreamer, a dream, we're unstoppable\r\nWith something to believe in\r\nMonday left me broken\r\nTuesday, I was through with hoping\r\nWednesday, my empty arms were open\r\nThursday, waiting for love, waiting for love\r\nThank the stars, it's Friday\r\nI'm burning like a fire gone wild on Saturday\r\nGuess I won't be coming to church on Sunday\r\nI'll be waiting for love, waiting for love to come around\r\nWe are one of a kind, irreplaceable\r\nHow did I get so blind and so cynical?\r\nIf there's love in this life, we're unstoppable\r\nNo, we can't be defeated\r\nMonday left me broken\r\nTuesday, I was through with hoping\r\nWednesday, my empty arms were open\r\nThursday, waiting for love, waiting for love\r\nThank the stars, it's Friday\r\nI'm burning like a fire gone wild on Saturday\r\nGuess I won't be coming to church on Sunday\r\nI'll be waiting for love, waiting for love to come around");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "If Only I Could":
                    {
                        int checklike = Convert.ToInt32(EDM.Rows[2]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EDM.Rows[2]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EDM.Rows[2]["liked"] = 1;
                                Like.Rows.Add("EDM", Properties.Resources.If_Only_I_Could, 0, "If Only I Could", "Brooks", "4:22", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Brooks - If Only I Could.wav", "Stronger than a brick house\r\nBigger than the moon and brighter than the stars\r\nIf I could move the mountains\r\nI would've known who you are\r\n'Cause I've been lookin' far a way to get lost in your eyes\r\nTryna find my way in this chaos\r\nIf I could walk on water\r\nI could've known who you are\r\nIf only I could be the one to say\r\nYou can't stop me now\r\n'Cause I've been lookin' for...\r\n'Cause I've been lookin' for...\r\nIf I'd shown you what I'm made of\r\nYou would've seen it into me\r\nIf I'd shown you what I'm made of\r\nMaybe you'll see into me\r\nFaster than a race car\r\nSharper than a knife and higher than the trees\r\nIf I'd shown you what I'm made of\r\nYou would've seen it into me\r\n'Cause I've been lookin' for a way to get lost in your eyes\r\nTryna find my way in this chaos\r\nIf I show you what I'm made of\r\nMaybe you'll see into me, to me\r\nYou're fallin'\r\nIf only I could be the one to say\r\nIf only I could be the one to say\r\nYou can't stop me now\r\n'Cause I've been lookin' for...\r\n'Cause I've been lookin' for...\r\nIf I'd shown you what I'm made of\r\nYou would've seen into me\r\nIf I'd shown you what I'm made of\r\nMaybe you'll see into me");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Journey":
                    {
                        int checklike = Convert.ToInt32(EDM.Rows[3]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EDM.Rows[3]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EDM.Rows[3]["liked"] = 1;
                                Like.Rows.Add("EDM", Properties.Resources.Journey, 0, "Journey", "Don Diablo", "3:13", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Don Diablo - Journey.wav", "Take me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me where you wanna go, go, go\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me where you wanna go, go, go\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Where Are You Now":
                    {
                        int checklike = Convert.ToInt32(EDM.Rows[4]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EDM.Rows[4]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EDM.Rows[4]["liked"] = 1;
                                Like.Rows.Add("EDM", Properties.Resources.Where_Are_You_Now, 0, "Where Are You Now", "Lost Frequencies", "2:53", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Lost Frequencies - Where Are You Now.wav", "You're just like my favorite song going 'round and 'round my head\r\nLike my favorite song going 'round and 'round my head\r\nFive days on the freeway\r\nRiding shotgun with you (yeah, yeah)\r\nTwo hearts in the fast lane\r\nWe had big dreams in blue (yeah, yeah)\r\nPlaying Sweet Child O' Mine\r\nAnd I still feel that line\r\nWhere are you now?\r\nWhere are you now?\r\nHey, it's been too long\r\nToo long to go, my love\r\nWhere did we go wrong?\r\nToo late to turn around\r\nWhere are you now?\r\nWhere are you now?\r\nHey, it's been too long\r\nYou're just like my favorite song going 'round and 'round my head\r\nLike my favorite song going 'round and 'round my head\r\nYou're just like my favorite song going 'round and 'round my head\r\nLike my favorite song going 'round and 'round my head\r\nHey, it's been too long\r\nSome days I can feel it\r\nBut the feeling ain't all blue\r\nYou got me believing\r\nOne day you gotta come through\r\nLost in these city lights\r\n'Cause I can't sleep tonight\r\nWhere are you now?\r\nWhere are you now?\r\nHey, it's been too long\r\nToo long to go, my love\r\nWhere did we go wrong?\r\nToo late to turn around\r\nWhere are you now?\r\nWhere are you now?\r\nHey, it's been too long\r\nYou're just like my favorite song going 'round and 'round my head\r\nLike my favorite song going 'round and 'round my head\r\nYou're just like my favorite song going 'round and 'round my head\r\nLike my favorite song going 'round and 'round my head\r\nWhere are you now?\r\nWhere are you now?\r\nWhere are you now?\r\nWhere are you now?\r\nWhere are you now?");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Silence":
                    {
                        int checklike = Convert.ToInt32(EDM.Rows[5]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EDM.Rows[5]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EDM.Rows[5]["liked"] = 1;
                                Like.Rows.Add("EDM", Properties.Resources.Silence, 0, "Silence", "Marshmallow", "3:06", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Marshmello - Silence.wav", "Yeah, I'd rather be a lover than a fighter (fighter)\r\n'Cause all my life, I've been fighting\r\nNever felt a feeling of comfort, oh\r\nAnd all this time, I've been hiding\r\nAnd I never had someone to call my own, oh nah\r\nI'm so used to sharing\r\nLove only left me alone\r\nBut I'm at one with the silence\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been quiet for too long\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been silent for too long\r\nI've been quiet for too long\r\nI've been quiet for too long\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been quiet for too long\r\nI'm in need of a savior (savior), but I'm not asking for favors\r\nMy whole life, I've felt like a burden\r\nI think too much, and I hate it\r\nI'm so used to being in the wrong, I'm tired of caring\r\nLoving never gave me a home, so I'll sit here in the silence\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been quiet for too long\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been silent for too long\r\nI've been quiet for too long\r\nI've been quiet for too long\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been quiet for too long");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Leyla":
                    {
                        int checklike = Convert.ToInt32(EDM.Rows[6]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EDM.Rows[6]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EDM.Rows[6]["liked"] = 1;
                                Like.Rows.Add("EDM", Properties.Resources.Leyla, 0, "Leyla", "Mesto", "3:07", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Mesto - Leyla.wav", "You were only 17\r\nLookin' at your window screen\r\nSweetest girl I've ever seen\r\nStraight up from a project dream\r\nYou were on the second floor\r\nI was right across from yours\r\nTwo different sides of war\r\nKinda like a west side story, now\r\nLeyla, I am in love with you, Leyla\r\nI'm comin' up any day now\r\nSo bust that window and come with me\r\nLeyla, get all your stuff and we'll break out\r\nBaby, I know what they'll say now\r\nBut I want you anyway\r\nBut I want you anyway\r\nBut I want you anyway\r\nNow we've turned 23\r\nYou've moved across town from me\r\nOur friends and family, wouldn't let us be happy\r\nI hear you're married now\r\nHear it ain't working out\r\nThey can't shut us down\r\nLeyla just tell me how and I'll be there\r\nYou are a goddess, I want you to know (oh-oh-oh-oh)\r\nI'll never forget you, I'll never let go\r\nYeah, I'll be comin' to get you\r\nLeyla, I am in love with you, Leyla\r\nI'm comin' up any day now\r\nSo bust that window and come with me\r\nLeyla, get all your stuff and we'll break out\r\nBaby, I know what they'll say now\r\nBut I want you anyway\r\nBut I want you anyway\r\nBut I want you anyway\r\nYou are a goddess, I want you to know (oh-oh-oh-oh)\r\nI'll never forget you, I'll never let go\r\nYeah, I'll be comin' to get you\r\nLeyla, I am in love with you, Leyla\r\nI'm comin' up any day now\r\nSo bust that window and come with me\r\nLeyla, get all your stuff and we'll break out\r\nBaby, I know what they'll say now\r\nBut I want you anyway\r\nBut I want you anyway\r\nLeyla, I am in love with you, Leyla\r\nI'm comin' up any day now\r\nSo bust that window and come with me\r\nLeyla, get all your stuff and we'll break out\r\nBaby, I know what they'll say now\r\nBut I want you anyway");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "When The Sun's Gone":
                    {
                        int checklike = Convert.ToInt32(EDM.Rows[7]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EDM.Rows[7]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EDM.Rows[7]["liked"] = 1;
                                Like.Rows.Add("EDM", Properties.Resources.When_The_Suns_Gone, 0, "When The Sun's Gone", "Mike William", "2:58", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Mike Williams - When The Sun Is Gone.wav", "When the sun, when the sun, when the sun is gone\r\nHold me tight when you feel like it all goes wrong\r\nTogether we'll be okay\r\nWe're the light in the world when the sun is gone (Is gone)\r\nWe'll be running red lights till the end of the road\r\nGonna make it, you and I, baby, that I know\r\nBut I'll hold you tight in my arms when the sun is gone (Is gone)\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nHold you tight in my arms when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nHold you tight in my arms when the sun is gone (Is gone)\r\nFollow me, I know we'll find higher ground\r\nAs long as we are together\r\nFind the path through the light where the dusk fades out (fade out)\r\nWe'll be running red lights till the end of the road\r\nGonna make it, you and I, baby, that I know\r\nBut I'll hold you tight in my arms when the sun is gone (Is gone)\r\nWhen the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nHold you tight in my arms when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nHold you tight in my arms when the sun is gone\r\n");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Bullet Waiting For Me":
                    {
                        int checklike = Convert.ToInt32(EDM.Rows[8]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EDM.Rows[8]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EDM.Rows[8]["liked"] = 1;
                                Like.Rows.Add("EDM", Properties.Resources.Bullet_Waiting_For_Me, 0, "Bullet Waiting For Me", "Nikki Simmons", "4:51", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Nikki Simmons - Bullet Waiting For Me.wav", "Standing on the open shore, in a world of disarray\r\n'Cause the chaos is a warm embrace\r\nAs the fire hits my body and my conscience is consumed\r\nNothing left of me but you, yeah\r\nAnd dancin' with my demons through and through\r\nJust stare into the distance for a chance to come around, take it\r\n\r\nThe final destination is at hand and for the first time in forever\r\nI feel the resolution, yeah\r\nThe shoreline keeps a’rising up to me, looking for my revolution\r\nThis is my chance to breathe, yeah-ah-ah-ah!\r\n\r\nLooking on the edge of fantasy; It’s a crashing wall of thunder\r\nAnd the roar of what I wish to believe is the bullet waiting for me\r\n\r\nLooking on the edge of fantasy; It’s a crashing wall of thunder\r\nAnd the roar of what I wish to believe is the bullet waiting for me");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
                case "Roses":
                    {
                        int checklike = Convert.ToInt32(EDM.Rows[9]["liked"]);
                        switch (checklike)
                        {
                            case 1:
                                picLike.BackgroundImage = Properties.Resources.unheart;
                                EDM.Rows[9]["liked"] = 0;
                                Like.Rows.RemoveAt(temp);
                                i--;
                                break;
                            case 0:
                                picLike.BackgroundImage = Properties.Resources.heart;
                                EDM.Rows[9]["liked"] = 1;
                                Like.Rows.Add("EDM", Properties.Resources.Roses, 0, "Roses", "The Chainsmokers", "3:50", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM The Chainsmokers - Roses.wav", "You brought one to my door\r\nStood there on the front porch\r\nThat was the beginning\r\nWe had those tires spinning\r\nDown to the green grass\r\nOutside of town\r\nWild and free, never slowing down\r\nI thought I needed you like air\r\nWe burned hot, burned out, like a flame\r\nBut in my head, you'll never fade\r\nYeah, we were classic\r\nMy dress, your leather jacket\r\nDidn't know how good we had it\r\nBut, boy, we had it\r\n14th of February, gotta feeling my heart still carries\r\nYeah, we didn't know it\r\nThought we could grow it\r\nBeautiful for a moment\r\nWe were roses\r\nWe were roses\r\nYou put one in my hair\r\nWe danced in the middle of nowhere\r\nYou and me all summer\r\nBright and living color\r\nMy lips were red\r\nYour eyes were blue\r\nAnd I thought I saw forever in you\r\nYeah, we were classic\r\nMy dress, your leather jacket\r\nDidn't know how good we had it\r\nBut, boy, we had it\r\n14th of February, gotta feeling my heart still carries\r\nYeah, we didn't know it\r\nThought we could grow it\r\nBeautiful for a moment\r\nWe were roses\r\nBut seasons had to change\r\nAnd like flowers they bloom and withered away\r\nYeah, we were classic\r\nMy dress, your leather jacket\r\nDidn't know how good we had it\r\nIt was so good while it lasted\r\nYeah, we were classic\r\nMy dress, your leather jacket\r\nDidn't know how good we had it\r\nBut, boy, we had it\r\n14th of February, gotta feeling my heart still carries\r\nYeah, we didn't know it\r\nThought we could grow it\r\nBeautiful for a moment\r\nWe were roses\r\nWe were beautiful for a moment, baby\r\nWe were roses\r\nWe were beautiful for a moment, baby\r\nWe didn't know it\r\nThought we could grow it\r\nBeautiful for a moment\r\nWe were roses");
                                i++;
                                temp = i;
                                break;
                        }
                        break;
                    }
            }
        }

        private void labelLiked_Click(object sender, EventArgs e)
        {
            flagvn = 0;
            flagen = 0;
            flagedm = 0;

            panelLiked.Visible = true;
            panelInfo.Visible = false;
            panelPlaylist.Visible = false;
            labelLikedCount.Text = (i + 1).ToString();

            switch (i)
            {
                case -1:
                    panelLiked1.Visible = false;
                    panelLiked2.Visible = false;
                    panelLiked3.Visible = false;
                    panelLiked4.Visible = false;
                    panelLiked5.Visible = false;
                    panelLiked6.Visible = false;
                    panelLiked7.Visible = false;
                    panelLiked8.Visible = false;
                    panelLiked9.Visible = false;
                    panelLiked10.Visible = false;
                    break;
                case 0:
                    panelLiked1.Visible = true;
                    panelLiked2.Visible = false;
                    panelLiked3.Visible = false;
                    panelLiked4.Visible = false;
                    panelLiked5.Visible = false;
                    panelLiked6.Visible = false;
                    panelLiked7.Visible = false;
                    panelLiked8.Visible = false;
                    panelLiked9.Visible = false;
                    panelLiked10.Visible = false;

                    picLiked1.BackgroundImage = (Image)Like.Rows[0]["hinhanh"];
                    labelLiked1.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked3.Text = Like.Rows[0]["tencasi"].ToString();
                    labelLiked2.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked4.Text = Like.Rows[0]["thoiluong"].ToString();
                    break;
                case 1:
                    panelLiked1.Visible = true;
                    panelLiked2.Visible = true;
                    panelLiked3.Visible = false;
                    panelLiked4.Visible = false;
                    panelLiked5.Visible = false;
                    panelLiked6.Visible = false;
                    panelLiked7.Visible = false;
                    panelLiked8.Visible = false;
                    panelLiked9.Visible = false;
                    panelLiked10.Visible = false;

                    picLiked1.BackgroundImage = (Image)Like.Rows[0]["hinhanh"];
                    labelLiked1.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked3.Text = Like.Rows[0]["tencasi"].ToString();
                    labelLiked2.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked4.Text = Like.Rows[0]["thoiluong"].ToString();

                    picLiked2.BackgroundImage = (Image)Like.Rows[1]["hinhanh"];
                    labelLiked5.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked7.Text = Like.Rows[1]["tencasi"].ToString();
                    labelLiked6.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked8.Text = Like.Rows[1]["thoiluong"].ToString();
                    break;
                case 2:
                    panelLiked1.Visible = true;
                    panelLiked2.Visible = true;
                    panelLiked3.Visible = true;
                    panelLiked4.Visible = false;
                    panelLiked5.Visible = false;
                    panelLiked6.Visible = false;
                    panelLiked7.Visible = false;
                    panelLiked8.Visible = false;
                    panelLiked9.Visible = false;
                    panelLiked10.Visible = false;

                    picLiked1.BackgroundImage = (Image)Like.Rows[0]["hinhanh"];
                    labelLiked1.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked3.Text = Like.Rows[0]["tencasi"].ToString();
                    labelLiked2.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked4.Text = Like.Rows[0]["thoiluong"].ToString();

                    picLiked2.BackgroundImage = (Image)Like.Rows[1]["hinhanh"];
                    labelLiked5.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked7.Text = Like.Rows[1]["tencasi"].ToString();
                    labelLiked6.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked8.Text = Like.Rows[1]["thoiluong"].ToString();

                    picLiked3.BackgroundImage = (Image)Like.Rows[2]["hinhanh"];
                    labelLiked9.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked11.Text = Like.Rows[2]["tencasi"].ToString();
                    labelLiked10.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked12.Text = Like.Rows[2]["thoiluong"].ToString();
                    break;
                case 3:
                    panelLiked1.Visible = true;
                    panelLiked2.Visible = true;
                    panelLiked3.Visible = true;
                    panelLiked4.Visible = true;
                    panelLiked5.Visible = false;
                    panelLiked6.Visible = false;
                    panelLiked7.Visible = false;
                    panelLiked8.Visible = false;
                    panelLiked9.Visible = false;
                    panelLiked10.Visible = false;

                    picLiked1.BackgroundImage = (Image)Like.Rows[0]["hinhanh"];
                    labelLiked1.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked3.Text = Like.Rows[0]["tencasi"].ToString();
                    labelLiked2.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked4.Text = Like.Rows[0]["thoiluong"].ToString();

                    picLiked2.BackgroundImage = (Image)Like.Rows[1]["hinhanh"];
                    labelLiked5.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked7.Text = Like.Rows[1]["tencasi"].ToString();
                    labelLiked6.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked8.Text = Like.Rows[1]["thoiluong"].ToString();

                    picLiked3.BackgroundImage = (Image)Like.Rows[2]["hinhanh"];
                    labelLiked9.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked11.Text = Like.Rows[2]["tencasi"].ToString();
                    labelLiked10.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked12.Text = Like.Rows[2]["thoiluong"].ToString();

                    picLiked4.BackgroundImage = (Image)Like.Rows[3]["hinhanh"];
                    labelLiked13.Text = Like.Rows[3]["tenbaihat"].ToString();
                    labelLiked15.Text = Like.Rows[3]["tencasi"].ToString();
                    labelLiked14.Text = Like.Rows[3]["tenbaihat"].ToString();
                    labelLiked16.Text = Like.Rows[3]["thoiluong"].ToString();
                    break;
                case 4:
                    panelLiked1.Visible = true;
                    panelLiked2.Visible = true;
                    panelLiked3.Visible = true;
                    panelLiked4.Visible = true;
                    panelLiked5.Visible = true;
                    panelLiked6.Visible = false;
                    panelLiked7.Visible = false;
                    panelLiked8.Visible = false;
                    panelLiked9.Visible = false;
                    panelLiked10.Visible = false;

                    picLiked1.BackgroundImage = (Image)Like.Rows[0]["hinhanh"];
                    labelLiked1.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked3.Text = Like.Rows[0]["tencasi"].ToString();
                    labelLiked2.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked4.Text = Like.Rows[0]["thoiluong"].ToString();

                    picLiked2.BackgroundImage = (Image)Like.Rows[1]["hinhanh"];
                    labelLiked5.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked7.Text = Like.Rows[1]["tencasi"].ToString();
                    labelLiked6.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked8.Text = Like.Rows[1]["thoiluong"].ToString();

                    picLiked3.BackgroundImage = (Image)Like.Rows[2]["hinhanh"];
                    labelLiked9.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked11.Text = Like.Rows[2]["tencasi"].ToString();
                    labelLiked10.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked12.Text = Like.Rows[2]["thoiluong"].ToString();

                    picLiked4.BackgroundImage = (Image)Like.Rows[3]["hinhanh"];
                    labelLiked13.Text = Like.Rows[3]["tenbaihat"].ToString();
                    labelLiked15.Text = Like.Rows[3]["tencasi"].ToString();
                    labelLiked14.Text = Like.Rows[3]["tenbaihat"].ToString();
                    labelLiked16.Text = Like.Rows[3]["thoiluong"].ToString();

                    picLiked5.BackgroundImage = (Image)Like.Rows[4]["hinhanh"];
                    labelLiked17.Text = Like.Rows[4]["tenbaihat"].ToString();
                    labelLiked19.Text = Like.Rows[4]["tencasi"].ToString();
                    labelLiked18.Text = Like.Rows[4]["tenbaihat"].ToString();
                    labelLiked20.Text = Like.Rows[4]["thoiluong"].ToString();
                    break;
                case 5:
                    panelLiked1.Visible = true;
                    panelLiked2.Visible = true;
                    panelLiked3.Visible = true;
                    panelLiked4.Visible = true;
                    panelLiked5.Visible = true;
                    panelLiked6.Visible = true;
                    panelLiked7.Visible = false;
                    panelLiked8.Visible = false;
                    panelLiked9.Visible = false;
                    panelLiked10.Visible = false;

                    picLiked1.BackgroundImage = (Image)Like.Rows[0]["hinhanh"];
                    labelLiked1.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked3.Text = Like.Rows[0]["tencasi"].ToString();
                    labelLiked2.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked4.Text = Like.Rows[0]["thoiluong"].ToString();

                    picLiked2.BackgroundImage = (Image)Like.Rows[1]["hinhanh"];
                    labelLiked5.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked7.Text = Like.Rows[1]["tencasi"].ToString();
                    labelLiked6.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked8.Text = Like.Rows[1]["thoiluong"].ToString();

                    picLiked3.BackgroundImage = (Image)Like.Rows[2]["hinhanh"];
                    labelLiked9.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked11.Text = Like.Rows[2]["tencasi"].ToString();
                    labelLiked10.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked12.Text = Like.Rows[2]["thoiluong"].ToString();

                    picLiked4.BackgroundImage = (Image)Like.Rows[3]["hinhanh"];
                    labelLiked13.Text = Like.Rows[3]["tenbaihat"].ToString();
                    labelLiked15.Text = Like.Rows[3]["tencasi"].ToString();
                    labelLiked14.Text = Like.Rows[3]["tenbaihat"].ToString();
                    labelLiked16.Text = Like.Rows[3]["thoiluong"].ToString();

                    picLiked5.BackgroundImage = (Image)Like.Rows[4]["hinhanh"];
                    labelLiked17.Text = Like.Rows[4]["tenbaihat"].ToString();
                    labelLiked19.Text = Like.Rows[4]["tencasi"].ToString();
                    labelLiked18.Text = Like.Rows[4]["tenbaihat"].ToString();
                    labelLiked20.Text = Like.Rows[4]["thoiluong"].ToString();

                    picLiked6.BackgroundImage = (Image)Like.Rows[5]["hinhanh"];
                    labelLiked21.Text = Like.Rows[5]["tenbaihat"].ToString();
                    labelLiked23.Text = Like.Rows[5]["tencasi"].ToString();
                    labelLiked22.Text = Like.Rows[5]["tenbaihat"].ToString();
                    labelLiked24.Text = Like.Rows[5]["thoiluong"].ToString();
                    break;
                case 6:
                    panelLiked1.Visible = true;
                    panelLiked2.Visible = true;
                    panelLiked3.Visible = true;
                    panelLiked4.Visible = true;
                    panelLiked5.Visible = true;
                    panelLiked6.Visible = true;
                    panelLiked7.Visible = true;
                    panelLiked8.Visible = false;
                    panelLiked9.Visible = false;
                    panelLiked10.Visible = false;

                    picLiked1.BackgroundImage = (Image)Like.Rows[0]["hinhanh"];
                    labelLiked1.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked3.Text = Like.Rows[0]["tencasi"].ToString();
                    labelLiked2.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked4.Text = Like.Rows[0]["thoiluong"].ToString();

                    picLiked2.BackgroundImage = (Image)Like.Rows[1]["hinhanh"];
                    labelLiked5.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked7.Text = Like.Rows[1]["tencasi"].ToString();
                    labelLiked6.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked8.Text = Like.Rows[1]["thoiluong"].ToString();

                    picLiked3.BackgroundImage = (Image)Like.Rows[2]["hinhanh"];
                    labelLiked9.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked11.Text = Like.Rows[2]["tencasi"].ToString();
                    labelLiked10.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked12.Text = Like.Rows[2]["thoiluong"].ToString();

                    picLiked4.BackgroundImage = (Image)Like.Rows[3]["hinhanh"];
                    labelLiked13.Text = Like.Rows[3]["tenbaihat"].ToString();
                    labelLiked15.Text = Like.Rows[3]["tencasi"].ToString();
                    labelLiked14.Text = Like.Rows[3]["tenbaihat"].ToString();
                    labelLiked16.Text = Like.Rows[3]["thoiluong"].ToString();

                    picLiked5.BackgroundImage = (Image)Like.Rows[4]["hinhanh"];
                    labelLiked17.Text = Like.Rows[4]["tenbaihat"].ToString();
                    labelLiked19.Text = Like.Rows[4]["tencasi"].ToString();
                    labelLiked18.Text = Like.Rows[4]["tenbaihat"].ToString();
                    labelLiked20.Text = Like.Rows[4]["thoiluong"].ToString();

                    picLiked6.BackgroundImage = (Image)Like.Rows[5]["hinhanh"];
                    labelLiked21.Text = Like.Rows[5]["tenbaihat"].ToString();
                    labelLiked23.Text = Like.Rows[5]["tencasi"].ToString();
                    labelLiked22.Text = Like.Rows[5]["tenbaihat"].ToString();
                    labelLiked24.Text = Like.Rows[5]["thoiluong"].ToString();

                    picLiked7.BackgroundImage = (Image)Like.Rows[6]["hinhanh"];
                    labelLiked25.Text = Like.Rows[6]["tenbaihat"].ToString();
                    labelLiked27.Text = Like.Rows[6]["tencasi"].ToString();
                    labelLiked26.Text = Like.Rows[6]["tenbaihat"].ToString();
                    labelLiked28.Text = Like.Rows[6]["thoiluong"].ToString();
                    break;
                case 7:
                    panelLiked1.Visible = true;
                    panelLiked2.Visible = true;
                    panelLiked3.Visible = true;
                    panelLiked4.Visible = true;
                    panelLiked5.Visible = true;
                    panelLiked6.Visible = true;
                    panelLiked7.Visible = true;
                    panelLiked8.Visible = true;
                    panelLiked9.Visible = false;
                    panelLiked10.Visible = false;

                    picLiked1.BackgroundImage = (Image)Like.Rows[0]["hinhanh"];
                    labelLiked1.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked3.Text = Like.Rows[0]["tencasi"].ToString();
                    labelLiked2.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked4.Text = Like.Rows[0]["thoiluong"].ToString();

                    picLiked2.BackgroundImage = (Image)Like.Rows[1]["hinhanh"];
                    labelLiked5.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked7.Text = Like.Rows[1]["tencasi"].ToString();
                    labelLiked6.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked8.Text = Like.Rows[1]["thoiluong"].ToString();

                    picLiked3.BackgroundImage = (Image)Like.Rows[2]["hinhanh"];
                    labelLiked9.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked11.Text = Like.Rows[2]["tencasi"].ToString();
                    labelLiked10.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked12.Text = Like.Rows[2]["thoiluong"].ToString();

                    picLiked4.BackgroundImage = (Image)Like.Rows[3]["hinhanh"];
                    labelLiked13.Text = Like.Rows[3]["tenbaihat"].ToString();
                    labelLiked15.Text = Like.Rows[3]["tencasi"].ToString();
                    labelLiked14.Text = Like.Rows[3]["tenbaihat"].ToString();
                    labelLiked16.Text = Like.Rows[3]["thoiluong"].ToString();

                    picLiked5.BackgroundImage = (Image)Like.Rows[4]["hinhanh"];
                    labelLiked17.Text = Like.Rows[4]["tenbaihat"].ToString();
                    labelLiked19.Text = Like.Rows[4]["tencasi"].ToString();
                    labelLiked18.Text = Like.Rows[4]["tenbaihat"].ToString();
                    labelLiked20.Text = Like.Rows[4]["thoiluong"].ToString();

                    picLiked6.BackgroundImage = (Image)Like.Rows[5]["hinhanh"];
                    labelLiked21.Text = Like.Rows[5]["tenbaihat"].ToString();
                    labelLiked23.Text = Like.Rows[5]["tencasi"].ToString();
                    labelLiked22.Text = Like.Rows[5]["tenbaihat"].ToString();
                    labelLiked24.Text = Like.Rows[5]["thoiluong"].ToString();

                    picLiked7.BackgroundImage = (Image)Like.Rows[6]["hinhanh"];
                    labelLiked25.Text = Like.Rows[6]["tenbaihat"].ToString();
                    labelLiked27.Text = Like.Rows[6]["tencasi"].ToString();
                    labelLiked26.Text = Like.Rows[6]["tenbaihat"].ToString();
                    labelLiked28.Text = Like.Rows[6]["thoiluong"].ToString();

                    picLiked8.BackgroundImage = (Image)Like.Rows[7]["hinhanh"];
                    labelLiked29.Text = Like.Rows[7]["tenbaihat"].ToString();
                    labelLiked31.Text = Like.Rows[7]["tencasi"].ToString();
                    labelLiked30.Text = Like.Rows[7]["tenbaihat"].ToString();
                    labelLiked32.Text = Like.Rows[7]["thoiluong"].ToString();
                    break;
                case 8:
                    panelLiked1.Visible = true;
                    panelLiked2.Visible = true;
                    panelLiked3.Visible = true;
                    panelLiked4.Visible = true;
                    panelLiked5.Visible = true;
                    panelLiked6.Visible = true;
                    panelLiked7.Visible = true;
                    panelLiked8.Visible = true;
                    panelLiked9.Visible = true;
                    panelLiked10.Visible = false;

                    picLiked1.BackgroundImage = (Image)Like.Rows[0]["hinhanh"];
                    labelLiked1.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked3.Text = Like.Rows[0]["tencasi"].ToString();
                    labelLiked2.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked4.Text = Like.Rows[0]["thoiluong"].ToString();

                    picLiked2.BackgroundImage = (Image)Like.Rows[1]["hinhanh"];
                    labelLiked5.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked7.Text = Like.Rows[1]["tencasi"].ToString();
                    labelLiked6.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked8.Text = Like.Rows[1]["thoiluong"].ToString();

                    picLiked3.BackgroundImage = (Image)Like.Rows[2]["hinhanh"];
                    labelLiked9.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked11.Text = Like.Rows[2]["tencasi"].ToString();
                    labelLiked10.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked12.Text = Like.Rows[2]["thoiluong"].ToString();

                    picLiked4.BackgroundImage = (Image)Like.Rows[3]["hinhanh"];
                    labelLiked13.Text = Like.Rows[3]["tenbaihat"].ToString();
                    labelLiked15.Text = Like.Rows[3]["tencasi"].ToString();
                    labelLiked14.Text = Like.Rows[3]["tenbaihat"].ToString();
                    labelLiked16.Text = Like.Rows[3]["thoiluong"].ToString();

                    picLiked5.BackgroundImage = (Image)Like.Rows[4]["hinhanh"];
                    labelLiked17.Text = Like.Rows[4]["tenbaihat"].ToString();
                    labelLiked19.Text = Like.Rows[4]["tencasi"].ToString();
                    labelLiked18.Text = Like.Rows[4]["tenbaihat"].ToString();
                    labelLiked20.Text = Like.Rows[4]["thoiluong"].ToString();

                    picLiked6.BackgroundImage = (Image)Like.Rows[5]["hinhanh"];
                    labelLiked21.Text = Like.Rows[5]["tenbaihat"].ToString();
                    labelLiked23.Text = Like.Rows[5]["tencasi"].ToString();
                    labelLiked22.Text = Like.Rows[5]["tenbaihat"].ToString();
                    labelLiked24.Text = Like.Rows[5]["thoiluong"].ToString();

                    picLiked7.BackgroundImage = (Image)Like.Rows[6]["hinhanh"];
                    labelLiked25.Text = Like.Rows[6]["tenbaihat"].ToString();
                    labelLiked27.Text = Like.Rows[6]["tencasi"].ToString();
                    labelLiked26.Text = Like.Rows[6]["tenbaihat"].ToString();
                    labelLiked28.Text = Like.Rows[6]["thoiluong"].ToString();

                    picLiked8.BackgroundImage = (Image)Like.Rows[7]["hinhanh"];
                    labelLiked29.Text = Like.Rows[7]["tenbaihat"].ToString();
                    labelLiked31.Text = Like.Rows[7]["tencasi"].ToString();
                    labelLiked30.Text = Like.Rows[7]["tenbaihat"].ToString();
                    labelLiked32.Text = Like.Rows[7]["thoiluong"].ToString();

                    picLiked9.BackgroundImage = (Image)Like.Rows[8]["hinhanh"];
                    labelLiked33.Text = Like.Rows[8]["tenbaihat"].ToString();
                    labelLiked35.Text = Like.Rows[8]["tencasi"].ToString();
                    labelLiked34.Text = Like.Rows[8]["tenbaihat"].ToString();
                    labelLiked36.Text = Like.Rows[8]["thoiluong"].ToString();
                    break;
                case 9:
                    panelLiked1.Visible = true;
                    panelLiked2.Visible = true;
                    panelLiked3.Visible = true;
                    panelLiked4.Visible = true;
                    panelLiked5.Visible = true;
                    panelLiked6.Visible = true;
                    panelLiked7.Visible = true;
                    panelLiked8.Visible = true;
                    panelLiked9.Visible = true;
                    panelLiked10.Visible = true;

                    picLiked1.BackgroundImage = (Image)Like.Rows[0]["hinhanh"];
                    labelLiked1.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked3.Text = Like.Rows[0]["tencasi"].ToString();
                    labelLiked2.Text = Like.Rows[0]["tenbaihat"].ToString();
                    labelLiked4.Text = Like.Rows[0]["thoiluong"].ToString();

                    picLiked2.BackgroundImage = (Image)Like.Rows[1]["hinhanh"];
                    labelLiked5.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked7.Text = Like.Rows[1]["tencasi"].ToString();
                    labelLiked6.Text = Like.Rows[1]["tenbaihat"].ToString();
                    labelLiked8.Text = Like.Rows[1]["thoiluong"].ToString();

                    picLiked3.BackgroundImage = (Image)Like.Rows[2]["hinhanh"];
                    labelLiked9.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked11.Text = Like.Rows[2]["tencasi"].ToString();
                    labelLiked10.Text = Like.Rows[2]["tenbaihat"].ToString();
                    labelLiked12.Text = Like.Rows[2]["thoiluong"].ToString();

                    picLiked4.BackgroundImage = (Image)Like.Rows[3]["hinhanh"];
                    labelLiked13.Text = Like.Rows[3]["tenbaihat"].ToString();
                    labelLiked15.Text = Like.Rows[3]["tencasi"].ToString();
                    labelLiked14.Text = Like.Rows[3]["tenbaihat"].ToString();
                    labelLiked16.Text = Like.Rows[3]["thoiluong"].ToString();

                    picLiked5.BackgroundImage = (Image)Like.Rows[4]["hinhanh"];
                    labelLiked17.Text = Like.Rows[4]["tenbaihat"].ToString();
                    labelLiked19.Text = Like.Rows[4]["tencasi"].ToString();
                    labelLiked18.Text = Like.Rows[4]["tenbaihat"].ToString();
                    labelLiked20.Text = Like.Rows[4]["thoiluong"].ToString();

                    picLiked6.BackgroundImage = (Image)Like.Rows[5]["hinhanh"];
                    labelLiked21.Text = Like.Rows[5]["tenbaihat"].ToString();
                    labelLiked23.Text = Like.Rows[5]["tencasi"].ToString();
                    labelLiked22.Text = Like.Rows[5]["tenbaihat"].ToString();
                    labelLiked24.Text = Like.Rows[5]["thoiluong"].ToString();

                    picLiked7.BackgroundImage = (Image)Like.Rows[6]["hinhanh"];
                    labelLiked25.Text = Like.Rows[6]["tenbaihat"].ToString();
                    labelLiked27.Text = Like.Rows[6]["tencasi"].ToString();
                    labelLiked26.Text = Like.Rows[6]["tenbaihat"].ToString();
                    labelLiked28.Text = Like.Rows[6]["thoiluong"].ToString();

                    picLiked8.BackgroundImage = (Image)Like.Rows[7]["hinhanh"];
                    labelLiked29.Text = Like.Rows[7]["tenbaihat"].ToString();
                    labelLiked31.Text = Like.Rows[7]["tencasi"].ToString();
                    labelLiked30.Text = Like.Rows[7]["tenbaihat"].ToString();
                    labelLiked32.Text = Like.Rows[7]["thoiluong"].ToString();

                    picLiked9.BackgroundImage = (Image)Like.Rows[8]["hinhanh"];
                    labelLiked33.Text = Like.Rows[8]["tenbaihat"].ToString();
                    labelLiked35.Text = Like.Rows[8]["tencasi"].ToString();
                    labelLiked34.Text = Like.Rows[8]["tenbaihat"].ToString();
                    labelLiked36.Text = Like.Rows[8]["thoiluong"].ToString();

                    picLiked10.BackgroundImage = (Image)Like.Rows[9]["hinhanh"];
                    labelLiked37.Text = Like.Rows[9]["tenbaihat"].ToString();
                    labelLiked39.Text = Like.Rows[9]["tencasi"].ToString();
                    labelLiked38.Text = Like.Rows[9]["tenbaihat"].ToString();
                    labelLiked40.Text = Like.Rows[9]["thoiluong"].ToString();
                    break;
            }
        }

        private void labelLiked1_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picLiked1.BackgroundImage;
            labelNowPlay.Text = labelLiked1.Text;
            labelNowArtist.Text = labelLiked3.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;
            
            player.Stop();
            player.SoundLocation = Like.Rows[0]["baihat"].ToString();
            player.Play();
             
        }

        private void labelLiked5_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picLiked2.BackgroundImage;
            labelNowPlay.Text = labelLiked5.Text;
            labelNowArtist.Text = labelLiked7.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Like.Rows[1]["baihat"].ToString();
            player.Play();
        }

        private void labelLiked9_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picLiked3.BackgroundImage;
            labelNowPlay.Text = labelLiked9.Text;
            labelNowArtist.Text = labelLiked11.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Like.Rows[2]["baihat"].ToString();
            player.Play();
        }

        private void labelLiked13_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picLiked4.BackgroundImage;
            labelNowPlay.Text = labelLiked13.Text;
            labelNowArtist.Text = labelLiked15.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Like.Rows[3]["baihat"].ToString();
            player.Play();
        }

        private void labelLiked17_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picLiked5.BackgroundImage;
            labelNowPlay.Text = labelLiked17.Text;
            labelNowArtist.Text = labelLiked19.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Like.Rows[4]["baihat"].ToString();
            player.Play();
        }

        private void labelLiked21_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picLiked6.BackgroundImage;
            labelNowPlay.Text = labelLiked21.Text;
            labelNowArtist.Text = labelLiked23.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Like.Rows[5]["baihat"].ToString();
            player.Play();
        }

        private void labelLiked25_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picLiked7.BackgroundImage;
            labelNowPlay.Text = labelLiked25.Text;
            labelNowArtist.Text = labelLiked27.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Like.Rows[6]["baihat"].ToString();
            player.Play();
        }

        private void labelLiked29_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picLiked8.BackgroundImage;
            labelNowPlay.Text = labelLiked29.Text;
            labelNowArtist.Text = labelLiked31.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Like.Rows[7]["baihat"].ToString();
            player.Play();
        }

        private void labelLiked33_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picLiked9.BackgroundImage;
            labelNowPlay.Text = labelLiked33.Text;
            labelNowArtist.Text = labelLiked35.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Like.Rows[8]["baihat"].ToString();
            player.Play();
        }

        private void labelLiked37_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picLiked10.BackgroundImage;
            labelNowPlay.Text = labelLiked37.Text;
            labelNowArtist.Text = labelLiked39.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Like.Rows[9]["baihat"].ToString();
            player.Play();
        }

        private void labelLiked1_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelLiked1.Font;
            labelLiked1.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelLiked1.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked1_MouseLeave(object sender, EventArgs e)
        {
            var font = labelLiked1.Font;
            labelLiked1.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelLiked1.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked5_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelLiked5.Font;
            labelLiked5.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelLiked5.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked5_MouseLeave(object sender, EventArgs e)
        {
            var font = labelLiked5.Font;
            labelLiked5.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelLiked5.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked9_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelLiked9.Font;
            labelLiked9.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelLiked9.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked9_MouseLeave(object sender, EventArgs e)
        {
            var font = labelLiked9.Font;
            labelLiked9.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelLiked9.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked13_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelLiked13.Font;
            labelLiked13.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelLiked13.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked13_MouseLeave(object sender, EventArgs e)
        {
            var font = labelLiked13.Font;
            labelLiked13.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelLiked13.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked17_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelLiked17.Font;
            labelLiked17.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelLiked17.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked17_MouseLeave(object sender, EventArgs e)
        {
            var font = labelLiked17.Font;
            labelLiked17.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelLiked17.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked21_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelLiked21.Font;
            labelLiked21.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelLiked21.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked21_MouseLeave(object sender, EventArgs e)
        {
            var font = labelLiked21.Font;
            labelLiked21.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelLiked21.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked25_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelLiked25.Font;
            labelLiked25.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelLiked25.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked25_MouseLeave(object sender, EventArgs e)
        {
            var font = labelLiked25.Font;
            labelLiked25.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelLiked25.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked29_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelLiked29.Font;
            labelLiked29.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelLiked29.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked29_MouseLeave(object sender, EventArgs e)
        {
            var font = labelLiked29.Font;
            labelLiked29.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelLiked29.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked33_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelLiked33.Font;
            labelLiked33.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelLiked33.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked33_MouseLeave(object sender, EventArgs e)
        {
            var font = labelLiked33.Font;
            labelLiked33.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelLiked33.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked37_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelLiked37.Font;
            labelLiked37.Font = new Font("Yu Gothic", 12, FontStyle.Underline);
            labelLiked37.ForeColor = Color.DarkSlateGray;
        }

        private void labelLiked37_MouseLeave(object sender, EventArgs e)
        {
            var font = labelLiked37.Font;
            labelLiked37.Font = new Font("Yu Gothic", 12, FontStyle.Regular);
            labelLiked37.ForeColor = Color.DarkSlateGray;
        }

        private void labelList7_Click(object sender, EventArgs e)
        {

        }
       
        int j = -1;
        private void buttonSavePlaylist_Click(object sender, EventArgs e)
        {
            switch(labelDecorMusic.Text)
            {
                case "#AiChoAi":
                    {                       
                        Playlist.Rows.Add("VN", Properties.Resources.ACA, 0, "#AiChoAi", "FloD", "2:40", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN FloD -  #AiChoAi.wav", "Sớm mai tỉnh dậy tôi lạc vào hư không\r\nĐôi tay níu lấy điều gì mà chờ mong\r\nNắng kéo mây về\r\nGió kéo đông về\r\nBuồn người thương kéo tôi về ngày yêu\r\nĐêm qua mơ thấy anh quay về\r\nÔm choàng nhau ấm áp đông qua\r\nThức giấc môi cười\r\nÔi là mơ thôi\r\nBuồn tôi ơi khi nào mày vơi\r\nAnh cứ đi đi tìm tình yêu mới\r\nTôi đứng đây ôm trọn tình yêu cũ\r\nNhắn gió mây gửi đến anh đôi lời\r\nSợi tơ duyên đứt đi rồi có nối lại được không\r\nAh anh chẳng thể nắm được duyên tình mặc dù luôn muốn giữ em cho riêng mình\r\nAnh chẳng thể giữ em lại đây mặc dù cô đơn vẫn cứ luôn bủa vây\r\nAnh biết trước hai ta phải xa nhau\r\nThêm lâu rồi niềm đau sẽ thêm sâu\r\nNhưng nếu ta xa nhau thì con tim này ai khâu\r\nAnh biết thời gian rồi vẫn qua\r\nThanh xuân cả hai rồi sẽ qua\r\nNhưng có những thứ cả hai chẳng thể xoá\r\nEm tồn tại trong anh là giấc mơ\r\nAnh đã tìm được em trong nỗi nhớ\r\nNhưng anh sống với hiện thực\r\nTình yêu còn đó chẳng kết thúc như giấc mơ\r\nEm đi qua như dòng chảy của dòng sông\r\nAnh là phiên đá cũ tự hỏi em về không\r\nEm đi qua dòng nước khác vẫn quanh anh\r\nNhưng anh lại cảm thấy nỗi cô đơn vẫn bao quanh\r\nAnh chẳng thể mua được thời gian\r\nChẳng thể yêu ngày hôm qua\r\nCâu chuyện giờ đã lật sang trang\r\nKết chuyện là anh nhìn em rời xa\r\nAnh cứ đi đi tìm tình yêu mới\r\nTôi đứng đây ôm trọn tình yêu cũ\r\nNhắn gió mây gửi đến anh đôi lời\r\nSợi tơ duyên đứt đi rồi có nối lại được không\r\nTừng giây phút\r\nNgày xưa đó\r\nNgười có nhớ\r\nNhớ\r\nNhớ\r\nNhớ không");
                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Không sao đâu":
                    {
                        Playlist.Rows.Add("VN", Properties.Resources.KSD, 0, "Không sao đâu", "cam", "4:54", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN cam - không sao đâu.wav", "CAM:\r\nYeah, hôm nay là ngày thứ mấy ở trong tuần\r\nNhiều cần đã cháy, nhiều lần đã thấy trước được hồi kết nhưng không tuân\r\nMấy lần những cuộc gọi nhỡ và lỡ có buông lời nói mớ, \r\nCũng nhớ gì đâu khi sâu trong óc vẫn còn quá nhiều điều đáng sợ.\r\nMọi thứ dường như đang quá tầm kiểm soát.\r\nCảm giác thế giới qua mặt được em, giờ đã xa tầm liên lạc.\r\nRồi em lại check Facebook, \r\nThâm tâm lại tự trách giây phút em nể bản than mình quá nhiều, \r\nEm để bản than mình hóa liều, quá liều.\r\nĐã bao lâu nay sao em không về nhà ?\r\nCòn phải bao nhiêu đêm trôi qua để mà em thôi rề rà ?\r\nEm nghe lời khuyên và điên từ tối qua,\r\nĐâu phải mê cung nào cũng tìm được lối ra.\r\nEm hay suy tư và dư ra thời giờ,\r\nVà đôi khi em không say no, bao niềm vui ai mời hờ (okay)\r\nChi ra bao nhiêu mua giấc mơ ?\r\nChi ra bao nhiêu ?\r\n\r\nIT’S ALRIGHT,\r\nCòn bao nỗi buồn, mình đâu muốn phải giấu ai.\r\nKhông sao em à, do it, IT’S ALRIGHT.\r\nVừa khóc, vừa cười này. (I wish I cared a little bit more)\r\n\r\nGIMME YOUR SOUL AND THEN GIMME YOUR… X3\r\n\r\nSHYNASTY:\r\nLang thang, lang thang\r\nBiết bao nhiêu ngày tháng, tâm bình thản, chân lang thang.\r\nNhìn những đám mây vàng nhẹ nhàng trôi lãng đãng, nhịp nhàng, đơn giản, ta chỉ muốn được mãn nhãn.\r\nLan man, lan man\r\nĐèn vàng chạng vạng, âm thanh xung quanh vang vang.\r\nKhông gì giới hạn bạn, con tim băng như đang tan.\r\nNhững gì chung tần số, hãy tìm cách để lan sang.\r\nTôi được dạy là không được thử, dù chỉ một lần,\r\nĐặt những thứ thay đổi tâm trạng, chạm gần tới môi.\r\nTôi đã nói không với suy nghĩ này rất nhiều lần,\r\nNhưng khổ nỗi suy nghĩ này lại không nói gì với tôi.\r\nĐôi khi không nguy hiểm như là người ta nghĩ,\r\nChỉ là một chuyến đi, nhưng không mang theo vali.\r\nNhư trôi đi Paris (yeah), như trôi về Bali (yeah).\r\nChỉ là đang giải trí, không cầu kì hay xa xỉ.\r\nCó những lúc ta bị (what), khó tính là đa nghi\r\nCuốn vào sự ma mị, while I’m getting money.\r\nNhững cảm giác lạ kì, nó đến và rồi ra đi.\r\nChỉ đơn giản là vì, đó là hiệu ứng suy nghĩ.\r\n\r\nIT’S ALRIGHT,\r\nCòn bao nỗi buồn, mình đâu muốn phải giấu ai.\r\nKhông sao em à, do it, IT’S ALRIGHT.\r\nVừa khóc, vừa cười này. (I wish I cared a little bit more)\r\n\r\nGIMME YOUR SOUL AND THEN GIMME YOUR… X3");
                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Sài Gòn buồn quá em ơi":
                    {
                        Playlist.Rows.Add("VN", Properties.Resources.SGBQEO, 0, "Sài Gòn buồn quá em ơi", "Dế Choắt", "5:18", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Dế Choắt - Sài Gòn buồn quá em ơi.wav", "Sài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi, em ơi\r\nSài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi\r\nSài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi, em ơi\r\nSài Gòn buồn quá\r\nEm ơi, em ơi, em ơi, em ơi\r\n\r\nAnh biết\r\nSài Gòn có những đêm buồn thức trắng\r\nLy cafe sữa vẫn còn vị ngọt nơi đầu môi\r\nAnh biết\r\nLà anh biết tất cả bộn bệ ở nơi mình từng\r\nLàm sao có thể thay đổi\r\nKhi chẳng có người đi cùng đổi thay\r\nTình đầu là tình vụn vỡ\r\nNgày mà mình chưa từng gặp gỡ\r\nNgày hôm qua quá nhiều chuyện buồn\r\nTrong từng nhịp thở\r\nCứ mãi cho đến một ngày\r\nNgày bình thường vô tình gặp nhau\r\nThì mới biết tim đã rối bời\r\nChẳng phải em thì chẳng tìm được đâu\r\nTâm hồn anh thì già cỗi\r\nChưa từng một lần rực rỗi\r\nMỗi khi thấy chân em dừng lại\r\nXin một lần hỏi\r\nNắng chói chang khắp chiều tà\r\nHoàng hôn yên vị xong rồi lại đi\r\nEm là thuyền trưởng\r\nAnh sẽ căng buồm\r\nChẳng ngại vì gió lau nhẹ bờ mi\r\nĐể cho anh một lần được nói\r\nCho anh một lần được hỏi\r\nPhải chăng anh là điểm tựa\r\nĐể em dựa mỗi ngày mệt mỏi?\r\nĐể cho anh một lần được nói\r\nCho anh một lần được hỏi\r\nNếu một ngày không gặp anh nữa\r\nEm có vội vàng đi tìm anh không?\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi lạc thì xem như mất nhau!\r\nNgười vội bước còn người đang đứng sau\r\nCần một điều ước để vượt qua nỗi đau\r\nDù phút chốc Sài Gòn vẫn vui\r\nSao anh mãi buồn?\r\nSài Gòn tháng năm sau\r\nAnh không, không còn em nữa đâu\r\nGiận rồi người cũng xa nhau\r\nQuên nhau, không còn nghĩ đến nhau\r\nNgày buồn nhất là ngày ta vỡ tan\r\nNgười ngồi khóc\r\nCòn người đang trách than\r\nNgày này tháng ấy mình rời bỏ nhau\r\nTrong đêm mưa buồn\r\n\r\nVì tình yêu đã lỡ một nhịp\r\nĐành phải nhường lại cho người đến sau\r\nKhi anh chỉ còn một nhịp\r\nAnh chỉ muốn thở hết những nỗi đau\r\nAnh không tin vào định mệnh\r\nAnh tin vào ngày mai\r\nNếu anh không thể làm được điều gì nữa\r\nThì chắc lẽ là anh sai\r\nVà em nên nhớ\r\nTình yêu không thể\r\nĐếm bằng ngày đâu em\r\nĐó là tất cả những gì đọng lại\r\nSau nhưng đêm dài buồn không tên\r\nĐến khi cảm xúc thấu được mình đã\r\nTrải qua quá nhiều lần tổn thương\r\nChiếc gương ấy sẽ xóa được hình bóng ai\r\nĐã khiến lòng mình vấn vương\r\nDù sai, dù đúng\r\nTất cả cũng không quan trọng vì\r\nNgười đi, người đến người ở lại\r\nLà vì hiểu nhau thì\r\nNgày em buồn nhất\r\nAnh sẽ đứng lại dù trời có mưa\r\nVà anh muốn hỏi tất cả chuyện buồn\r\nEm đã cất chưa\r\nBình yên là lúc ta cùng nhìn lại\r\nNở một nụ cười cho dù đớn đau\r\nBình yên là lúc có người tồn tại\r\nLuôn nằm phía sau\r\nTình yêu đẹp nhất khi lòng thù hận\r\nEm cần vứt đi\r\nTình yêu chỉ đến sau những mảnh vụn\r\nCó kẻ ghép lại, lau nhẹ ướt mi\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi lạc thì xem như mất nhau!\r\nNgười vội bước còn người đang đứng sau\r\nCần một điều ước để vượt qua nỗi đau\r\nDù phút chốc Sài Gòn vẫn vui\r\nSao anh mãi buồn?\r\nSài Gòn tháng năm sau\r\nAnh không, không còn em nữa đâu\r\nGiận rồi người cũng xa nhau\r\nQuên nhau, không còn nghĩ đến nhau\r\nNgày buồn nhất là ngày ta vỡ tan\r\nNgười ngồi khóc\r\nCòn người đang trách than\r\nNgày này tháng ấy mình rời bỏ nhau\r\nTrong đêm mưa buồn\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi, lạc thì xem như mất nhau!\r\nSài Gòn buồn quá em ơi\r\nEm ơi, em giờ đang ở đâu?\r\nSài Gòn buồn quá em ơi\r\nEm ơi, lạc thì xem như mất nhau!");
                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Trốn tìm":
                    {
                        Playlist.Rows.Add("VN", Properties.Resources.TT, 0, "Trốn Tìm", "Đen", "4:12", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Đen - Trốn Tìm.wav", "Có một cái cây trong một cái vườn\r\nTrên những tán cây nở rộ những đoá hoa\r\nCó hai đứa nhóc đang chơi trốn tìm\r\nTìm hoài tìm mãi nên quên lối về\r\nAnh đi tìm thì em trốn anh đi trốn em không tìm\r\nLòng em không gợn sóng cuối cùng anh mất công chìm\r\nNếu mà có cây búa anh sẽ nện cho bõ công\r\nVì nhớ nhung đặc quánh giờ nó khô thành bê tông\r\nChúng ta rồi sẽ có có những chuyến đi dài\r\nTa tự học lấy mọi thứ vì trong tình trường làm biếng ghi bài\r\nCâu chuyện của chúng ta bỗng có thêm một miếng bi hài\r\nVì cách mà em gọi anh không có u và thiếu y dài\r\nPhía xa thành phố người ta đã bật đèn đường\r\nHương quen xưa làm anh thấy thật thèm thuồng\r\nNỗi buồn vàng rực cứ như là chứa đồng thau\r\nHệt như là Beckham vậy em chỉ giỏi cứa lòng nhau\r\nHé cửa sổ ra mà xem\r\nCó một chàng thi sĩ đứng ở ngay nhà em\r\nViết nhạc tình mát ngọt tựa như cây cà rem\r\nAnh ta sẽ đứng ở nơi đây cả đêm\r\nCó hai cái cây trong một cái vườn (có hai cái cây trong vườn)\r\nTrên những tán cây nở rộ những đoá hoa (có những đoá hoa trên cành)\r\nCó hai đứa nhóc đang chơi trốn tìm (có hai đứa nhóc đang chơi)\r\nTìm hoài tìm mãi nên quên lối về\r\nHồi đó anh rụt rè như đám cây mắc cỡ\r\nGần em làm anh hồi hộp tới mức gây tắc thở\r\nTa đều không biết có điều gì sau đám mây sắp nở\r\nTrò chơi trốn tìm ngày đó sau này đầy trắc trở\r\nTa săn bắn những khát vọng và hái lượm những giấc mơ\r\nTa gieo trồng cây ước mộng thứ mà lấy đi nhiều thì giờ\r\nTa đào những cái hố mà không biết có ngày bị lọt\r\nĐể rất lâu sau này chúng ta cau mày nhận ra không phải tất cả bông hoa thì đều sẽ có những nhụy ngọt\r\nGọi tên em làm anh mất giọng hoài\r\nHệt như là một giấc mộng dài\r\nTa đi tìm cả thế giới nhưng mà lại trốn nhau\r\nBiết vậy thà nghỉ chơi từ lúc mới chớm đau (từ lúc mới chớm đau)\r\nNgười đi tìm cái người đi trốn\r\nNgười đi trốn cái người đi tìm\r\nTình yêu từ những ngày xưa đã\r\nNgủ quên dưới tán cây im lìm\r\nCó ba cái cây trong một cái cái vườn\r\nTrên những tán cây nở rộ những đoá hoa\r\nCó hai đứa nhóc đang chơi trốn tìm\r\nTìm hoài tìm mãi nên quên lối về\r\nAi đó đã chặt hết cây và cũng chẳng thấy vườn (chẳng thấy cây trong vườn)\r\nAi đó đã xây một ngôi nhà rất to (chặt hết cây đi rồi)\r\nChắc em hạnh phúc yên vui với người (chắc em hạnh phúc yên vui)\r\nNhà em có chó anh không dám vào\r\nNiềm cô đơn của những người trưởng thành\r\nLà khi muốn trốn nhưng không ai tìm\r\nNhiều khi ta muốn ta được bé lại\r\nĐể khi đi trốn có người đi tìm\r\nNhiều khi ta muốn ta được bé lại\r\nĐể khi đi trốn có người đi tìm");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Loving You Sunny":
                    {
                        Playlist.Rows.Add("VN", Properties.Resources.LYS, 0, "Loving You Sunny", "Kimmese", "4:56", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Kimmese - Loving You Sunny.wav", "Thoát ra mối sầu đêm nay\r\nCho em gối đầu lên tay\r\nKhông cần thuê người tư vấn\r\nYên tâm mình sẽ tự phối màu thêm hay\r\nAnh sẽ pha màu nhạt khói\r\nVào màu trầm của môi em\r\nVà nếu bên nhau là lạc lối\r\nThì mình cứ để mọi thứ kia trôi êm\r\nI wish you could give me another chance\r\nHave you ever thought of us as a future plan\r\nInside my heart, I know I don't wanna give up\r\nUntil i can have your love\r\nI know it worths it baby\r\nI know what makes me happy is you\r\nNobody could\r\nKiss me like the way you do\r\nThe way you talk to me, yeah\r\nI don't need no drugs only your love make me feel that high\r\nSunny that's why I love you\r\nOnly you can make me feel, in love again\r\nPicture me in the battle, finding you again\r\nI can feel a sunshine, in me one more time\r\nWhenever I see yo green eyes\r\nThats why I love you sunny\r\nHere's my heart just take it everywhere you go\r\nDestiny will bring me back to you for show\r\nWoah, I know you got everything i want\r\nIf you still love me\r\nGive me a chance\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h-oh-oh, Sunny\r\nYou\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h oh-oh, Sunny\r\nYou\r\nYou're amazing you're unique\r\nAnd you're bad\r\nYour lifestyle, interesting, passionate\r\nAnd I adore you\r\nBy the way you carry yourself\r\nBabe, you do it so well\r\nAnd I like that, like that\r\nI wanna show you my real world\r\nNo acting up, no playing games\r\nNo wall\r\nJust spend with me and u will see\r\nWe are meant to be\r\nCause i'm your baby\r\nOnly you can make me feel in love again\r\nPicture me in the battle, finding you again\r\nI can feel a sunshine in me one more time\r\nWhenever I see yo green eyes\r\nThats why I love you sunny\r\nHere's my heart just take it everywhere you go\r\nDestiny will bring me back to you for show\r\nWoah, I know you got everything i want\r\nIf you still love me\r\nGive me a chance\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h-oh-oh, Sunny\r\nYou\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h oh-oh, Sunny\r\nYou\r\nEm không cần mặc đẹp, vì anh thích lôi thôi\r\nGiam em bằng vòng tay rộng và\r\nTra tấn em bằng đôi môi\r\nLòng mình vui như tết á\r\nKhông cần chờ đêm ba mươi\r\nThả mình vào trong biển lớn\r\nKhông cần buồm mà ra khơi\r\nVì mình có quá nhiều ngày cô đơn nên ngày bên em dường như là không đủ\r\nMình sẽ phải cần thêm nhiều cà phê hơn\r\nVì đêm nay chúng ta sẽ không ngủ\r\nAnh sẽ vặn ngược lại kim của đồng hồ\r\nĐể nó luôn chỉ thời khắc nửa đêm\r\nTa sẽ có một ngày dài như là thế kỷ như vậy mới đủ để cho anh hiểu em\r\nNói lời chân thật với nhau, đừng bắt tâm tư phải sàng và lọc\r\nEm cần may túi ba gang vì lúc bên nhau là vàng là ngọc\r\nCó hàng tá rapper ngoài kia nhưng sẽ không có một Đen thứ hai\r\nViết cho em những điều kì lạ, em sẽ nhận ra chỉ Đen chứ ai\r\nBởi vì anh không thích đồ ngọt nên hãy yêu nhau theo cách mặn mà\r\nCứ yên tâm nhạc tình Đen viết luôn đặc quánh và rất đậm đà\r\nChắt chiu như trong một sớm trên lá đọng vệt trong ngần sương\r\nYêu em như cách anh viết nhạc, luôn cần mẫn mà không cần lương\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h-oh-oh, Sunny\r\nYou\r\nOh-h-h, Sunny\r\nL-o-v-i-n-g\r\nOh-h-h oh-oh, Sunny\r\nYou");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Chuyện chàng trông xe":
                    {
                        Playlist.Rows.Add("VN", Properties.Resources.CCTX, 0, "Chuyện chàng trông xe", "MCK", "3:15", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN MCK - Chuyện chàng trông xe.wav", "một toán học sinh lại đến\r\ncầm phấn viết lên yên xe\r\n24 25 biết khi nào xong\r\n“Xe em cho thẳng vào trong nhé”\r\nVina còn chưa kịp châm\r\ntrà đá vẫn chưa kịp nhấp môi\r\nTrời sập tối mưa rào\r\n\r\ndòng xe chắp nối đưa vào\r\n\r\nvà em \r\nsố xe 07 em ra mà xem\r\n\r\nlàm anh nhớ mong cả đêm\r\n\r\nthế nhưng cái tên lại quên\r\nvà anh\r\nlàm nghề cầm phấn nhưng không ai nghe\r\nBa anh lái xe bảo học không nghe\r\nthế nên giờ đây số kiếp trông xe\r\nđừng làm anh mong nhớ\r\nsánh đôi có lẽ chỉ ở trong mơ thôi\r\nchạm mặt em xong lỡ\r\ntrái Tim vụn vỡ lại đập loạn nhịp mong chờ\r\n\r\nsinh ra ở khu lao động không đi trông xe thì cũng xách vữa\r\nphổ biến là làm lao công còn muốn nghèo có thêm chục cách nữa\r\nBố mẹ anh không đủ tiền cho anh đi học cùng bạn trang lứa\r\nCây phấn mỗi ngày anh dùng phủ cuộc đời anh trắng thêm trang nữa\r\nđồng phục, tóc búi, cười hiền đi converse và em sơ vin\r\nlướt qua là anh muốn cưới, lấy giấy tờ, bỏ vào all in ô in\r\nEm như cây bút chì màu vẽ cuộc đời anh ở khung hình riêng\r\nThơ ngay 1 chút tình đầu anh muốn xoá bỏ đi những định kiến\r\nbố mẹ vẫn bảo anh là “sao mày đũa mốc mà chòi mâm son”\r\nhọc toán còn chưa ăn ai bây h mày thích học đòi không con\r\nmuốn đưa vé xe cho em nhưng anh lại sợ làm dơ áo trắng\r\nGiọng em ngọt như kem làm cổ họng anh tự nhiên nó đắng\r\n\r\ntương tư về em mỗi đêm cùng với thăng long anh lười không ngủ\r\ntưởng như chỉ yêu mỗi em dưới ánh trăng cong chửi “người âm phủ”\r\nmấy thằng con trai miệng lưỡi dẻo quẹo thì xin em đừng cả tin\r\nngoài đời thì nó thả bả còn lên mạng thì nó thả tim\r\n1 túp lều tranh 2 trái Tim vàng thì chắc bây giờ không có\r\nNgày 2 chúng ta yêu nhau thì chắc là ngày mặt trời không ló\r\nbố mẹ em cần ví dày nhưng giống bụng anh ví anh lép kẹp\r\nnhà anh có mỗi cửa sổ nên chuyện tình mình giờ chắc khép đẹp");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Anh không thề gì đâu anh làm":
                    {
                        Playlist.Rows.Add("VN", Properties.Resources.AKTGDAL, 0, "Anh không thề gì đâu anh làm", "Phúc Du", "2:10", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN PHÚC DU - ANH KHÔNG THỀ GÌ ĐÂU ANH LÀM.wav", "Ngày tháng có em bên cạnh trôi qua như một cơn mơ nhanh\r\nAnh có phải là bắp rang đâu mà em bơ anh\r\nEm ơi, xin đừng giận anh, đừng làm khó thêm\r\nTrong tim anh em như là Hawkeye, vì em luôn có tên\r\nEm luôn đứng đầu, em luôn đứng đầu\r\nDù em như bị trúng gió, em cứng cổ và cứng đầu\r\nAnh yêu em và nhiều đêm, tương tư anh lại nhiều thêm\r\nNgười ta thích là chiều ta, còn anh thì chỉ thích chiều em\r\nBên cạnh em anh luôn là khó ngầu\r\nVì nếu tim anh là mùa xuân, em là cơn gió đầu\r\nNghĩ về em cả hàng giờ, anh không mong tim em có sầu\r\nYêu em như một bàn cờ, anh mong kết cục có hậu\r\nTa cạn say, chén rượu xuân cay nồng và ngắm cánh nhạn bay\r\nChuyện tình ta như Iphone, mở ra từ cái chạm tay\r\nAnh không muốn thấy đạn bay và tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không muốn thấy đạn bay, tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm\r\nAnh nói thật là anh ghét nhất những lần ta cãi vã\r\nKhông phải chuyển giới nhưng đôi lúc anh thấy em thái quá\r\nĐâu là lí do đấy là thứ anh còn tìm\r\nNhiều lúc không biết anh đang yêu em hay anh đang chơi dò mìn\r\nNgày mà em giận, anh thấy u ám như ngày mưa\r\nSợ tình ta sẽ phải úa tàn như là vườn hồng ngày xưa\r\nĐến với em anh ôm hi vọng còn mưu mẹo thì quên đem\r\nĐếch cần 36 kế, anh chỉ cần kế bên em\r\nThương em từ sáng tới lúc trời tối đen thui\r\nHọ gọi anh là MC nhưng anh chỉ muốn làm em vui\r\nNên dù em đã nhận lời yêu anh vẫn còn thèm cưa em\r\nEm không đẹp như siêu mẫu mà siêu mẫu họ đẹp như em\r\nTừ ngày hẹn hò em làm anh thêm thói quen\r\nGiờ anh thích ăn kem vì trong kem có em\r\nEm cứ yên tâm, anh sẽ không để tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không thề gì đâu\r\nAnh không thề gì đâu, yeah\r\nAnh không muốn thấy đạn bay, tình ta nhanh tàn\r\nVì riêng với em thì anh không thề gì đâu mà anh làm");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Trên Lầu Cao":
                    {
                        Playlist.Rows.Add("VN", Properties.Resources.TLC, 0, "Trên Lầu Cao", "Rhymastics", "3:56", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Rhymastic - Trên Lầu Cao.wav", "Money flows in, money flows out\r\nBeware of the fishin' round it\r\nTao đi đường riêng\r\nCho dù còn bao nhiêu là ánh mắt vẫn đang liếc đi theo rình\r\n(Haters thì sao?)\r\nHaters thì sao?\r\nHỏi thằng nào mà không biết tên tao?\r\nTao mải là tao nên chưa kịp tiếp thằng nào\r\nMuốn được biết thì xuống tít bên dưới xếp hàng mau (Lineup)\r\nLife's the peephole (Yeah)\r\nYou see what your mind wanna believe though (No lie)\r\nNên tao đâu cần đi đầu (Nope)\r\nCứ đi theo lời mách bảo trong lí trí tao (That's right)\r\nYeah, cũng có lúc tao lạc mất tiết tấu\r\nYeah, cũng có lúc nhịp tao lơi\r\nVẫn lean on xuống deep low\r\nĐể nhịp swing bám vào beat và lời\r\n(Nhịp swing bám vào beat và lời)\r\n(Nhịp swing bám vào beat và lời)\r\nYeah\r\nVà khi sang ngày mới những vương bận chỉ còn là nốt nhạc cũ rích mà thôi (move up)\r\nĐạp mạnh chân ga cho bô nhả khói\r\nĐâu ai đi lạc lối cả đời?\r\nTầm nhìn mày liệu có vươn xa tới?\r\nHay là trên lời nói đầu môi?\r\nVạn vật đổi dời\r\nTao đâu dừng chân chờ ngày tàn kia đuổi tới\r\nTao đâu ngồi than khi thời gian đang tuột trôi\r\nBao nhiêu ngổn ngang đâu cần mang theo cuộc chơi?\r\nCàng nhiều buộc trói\r\nMày có thở nổi khi càng ngày càng lên cao?\r\nKhông gian càng loãng những cám dỗ càng biến ảo\r\nVà nếu mày không biết tao\r\nChắc mày nghĩ đây chỉ là câu chuyện hão (Yeah)\r\nNhạc high as em nghe theo bao nhiêu lâu? (Low)\r\nUnderground nhưng phát ở trên tầng lầu (low)\r\nSo high I paralyzed from down below (low)\r\nUnderground getting down with top flo' (low)\r\nLà underground trên lầu cao\r\n(It's how we roll around here)\r\nUnderground trên lầu cao\r\n(It's high level now)\r\nUnderground trên lầu cao\r\n(It's how we roll around here)\r\nLà underground trên lầu cao\r\nĐời ngắn có lúc đắng có lúc say\r\nChỉ sợ là mình lắm lúc mất trắng những phút giây\r\nNhiều người chìm đắm bao nhiêu năm vẫn cứ vậy\r\nThì liệu mày còn buồm căng qua vũng lầy?\r\nHay là mày thích nghe kể khổ?\r\nThích nghe kể nghèo?\r\nThích an ủi mình chùn tay?\r\nĐể rồi rả rích điệp khúc cũ\r\n\"Vì đời lắt léo thì mới chọn đường cùng này\"\r\nĐâu cần vạch đích để biết mình đang chạy\r\nCần gì thành tích để khích mình hăng say\r\nĐời người thành bại đều do mình giằng lấy\r\nKẻ vươn xa người đứng lại đều nằm ở tầm tay\r\nVì ngày mai biết được ai sẽ bị thay mới\r\nDại gì phí hoài để tương lai trôi\r\nKiếp này được vươn vai để mày trải đời\r\nLiệu mày có lại ngồi dưới đáy than đời phai phôi?\r\nVì sẽ có kẻ chỉ nói mà không làm\r\nNgười càng đói lại càng thích phàn nàn\r\nThành công vang dội thì cần gì lan man\r\nKhi chẳng cần nhiều lời miệng đời vẫn bàn tán\r\nDù lòng mày còn vướng bận, nghiệp mày còn gian nan\r\nThì cứ lấy danh dự làm la bàn\r\nChỉ cần nhớ được rằng, đêm tối dù hoạn nạn\r\nĐừng quay lưng khi mày tỏa sáng\r\nNên sân khấu này bật xuyên đêm\r\nNơi tao đứng Spaceboys luôn thức\r\nTúc trực cho những người anh em\r\nMượn lời bằng nhạc dắt nhau tới tận cùng\r\nAi cũng có thể được mời đến\r\nNhưng bản lĩnh mới được ngồi bàn trong\r\nVì tiền ở đây tha hồ đếm, khi có trình độ đúc từ vàng ròng\r\nNhạc high as em nghe theo bao nhiêu lâu? (Bao nhiêu lâu?)\r\nUnderground nhưng phát ở trên tầng lầu (Trên tầng lầu)\r\nSo high I paralyzed from down below (Chears to all my brothers and sisters)\r\nUnderground getting down with top flo'\r\nGet down!\r\nUnderground trên lầu cao\r\n(It's how we roll around here)\r\nUnderground trên lầu cao\r\n(It's high level now)\r\nUnderground trên lầu cao\r\n(It's how we roll around here)\r\nLà underground trên lầu cao");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Nhập gia tùy tục":
                    {
                        Playlist.Rows.Add("VN", Properties.Resources.NGTT, 0, "Nhập gia tùy tục", "Sol7", "3:56", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Sol7 - Nhập Gia Tuỳ Tục.wav", "You know me\r\nYou know me, yeah\r\nNgồi lên ngựa sắt\r\nLái qua phố riêng mình ta\r\nTrên chiến trường\r\nNhưng đang hát tình ca\r\nNgười đánh giá ta\r\nQua vài tấm hình mà\r\nÔng bà đã nói\r\nPhải biết trông rộng nhìn xa\r\nLập chiến tích không gây chiến tranh\r\nHoàn thành rồi anh em mình biến nhanh\r\nNhập gia thì tùy tục\r\nAnh hiền, ừ cũng tùy lúc\r\nMái đầu 7/3 cầm cây guitar rồi gảy ra\r\nĐứng yên như cột cờ nhưng ai ai cũng thấy ta\r\nKhông phải vận động viên nhưng mùa này anh nhảy xa\r\nÁp lực nặng như đá, ta là nước cứ chảy qua\r\nSăn tiền thưởng như cao bồi, uh\r\nAnh em đều có phần đam mê được trau dồi\r\nChẳng cần bước lên cao ngồi\r\nNói anh thất bại giờ mấy đứa nó sao rồi\r\nOn top ở trên tuần báo\r\nLấy tên tuổi cho thằng em bán quần áo\r\nLàm cho cả băng DCOD giá trị gia tăng\r\nỞ trong khu có người tự hào, thằng đó là bạn mình\r\nCòn nụ cười khinh thì anh coi như nó đang tàng hình\r\nFly Team, bay một đàn như loài chim\r\nĐể lại dấu ấn trên da như ngòi kim\r\nTừ đời thiệt ra lời viết\r\nHiên ngang giữa mọi thời tiết\r\nDòng đời và âm nhạc\r\nMuốn anh phải liều lĩnh\r\nThời gian là tiền bạc anh cần phải điều chỉnh\r\nNgồi lên ngựa sắt\r\nLái qua phố riêng mình ta\r\nTrên chiến trường\r\nNhưng đang hát tình ca\r\nNgười đánh giá ta\r\nQua vài tấm hình mà\r\nÔng bà đã nói\r\nPhải biết trông rộng nhìn xa\r\nMình tiến lên trong cuộc chơi mọi thứ an bài\r\nTui làm nhạc ông mê đá banh anh em ngang tài\r\nMàu cờ anh đưa lên thang dài\r\nĐón em anh đem vào trang đài\r\nBuổi sáng đang soi mái đầu anh chải\r\nChiều em mặc đồ bơi bên biển xanh mãi\r\nTối đi nghe nhạc để sầu nhanh giải\r\nBỏ ngoài tai trên mạng còn nhiều tranh cãi\r\nVẫn chờ người về đây ta cùng bay đến tương lai\r\nSợ gì vài cây, ngựa hay phải chạy đường dài\r\nNhư Cowboy viễn Tây đôi tay nhanh hơn chướng ngại\r\nKhông cần sắt đá ta vẫn xây nên tượng đài\r\nYou know I'm keeping my weapon like a soldier\r\nGiữa chặng đường dừng lại hét lên thử thách anh đâu sợ\r\nChẳng hề độc bước gia đình anh em ở sau chờ\r\nMỗi lần buồn phiền hãy ngước lên gọi Hallelujah\r\nTrôi dạt mênh mông như mây ở trên không\r\nGiọng anh trầm, yeah anh không cần lên tone\r\nGiọng anh trầm, yeah anh không cần lên tone\r\nAnh không cần lên tone\r\nNgồi lên ngựa sắt\r\nLái qua phố riêng mình ta\r\nTrên chiến trường\r\nNhưng đang hát tình ca\r\nNgười đánh giá ta\r\nQua vài tấm hình mà\r\nÔng bà đã nói\r\nPhải biết trông rộng nhìn xa\r\nNhẹ chạm bờ môi em mượt mà như câu thở\r\nGần nhau thật lâu làm màu son lại mau mờ\r\nThả thêm vài câu em nói anh câu giờ\r\nTừ lời, từng flow người anh thi người cover\r\nAnh rap khi có phiêu, keep it real\r\nĐiều chưa có không dám nêu, không nói điêu\r\nAnh đã thiêu những quá khứ, anh có tàn tro đen\r\nTừ bùn lầy anh ngoi lên chẳng khác gì hoa sen, graaa!");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Blue Tequila":
                    {
                        Playlist.Rows.Add("VN", Properties.Resources.BT, 0, "Blue Tequila", "Táo", "4:21", " ", "D:\\CS511 C# Language\\music\\musicdemo\\vn\\VN Táo - Blue Tequila.wav", "Hai tequila như mọi khi trong tuần\r\nNhạc bật Frank Sinatra nhưng mà tôi không cần\r\nBuồn phiền từ đâu lao đến đây vây quanh\r\nMệt nhoài cùng tôi đang nắm tay\r\nEm ra ban công vô tình đi ngang quầy\r\nHình như em đang say sau vài ly vang đầy\r\nTình cờ đời ta va lấy nhau, không may\r\nNgười tìm được tôi nơi đáy sâu\r\n\r\nBồi hồi nhìn nhau điếu thuốc kia đang tàn\r\nNgoài đường dòng xe nối tiếp nhau vội vàng\r\nNhiều lần hợp tan nuối tiếc trong muộn màng\r\nChỉ cần một ai xoá hết đi thời gian\r\nĐừng làm trời lên khói thuốc kia thay màu\r\nĐừng làm bầu không khí chuốc thêm ưu sầu\r\nĐừng làm tình ta sẽ chết ngay ban đầu\r\nDù mập mờ không biết sẽ đi về đâu.\r\n\r\nVà người nhìn bằng đôi mắt khép hờ lại bờ môi\r\nMột người làm lòng tôi muốn có một người cần tôi\r\nSau bao dối gian trong đời\r\nYêu đương hoá ra không lời, nên...\r\nNgười chìm mình vào ao ước biến cuộc tình thành phim\r\nNgười vì vài lần đau đớn bắt lòng mình lặng im\r\nRiêng tôi sẽ luôn yêu người\r\nNhư tôi đã luôn yêu người\r\nTừ đầu.\r\n\r\nEm thở nhẹ một sợi khói, khiến bầu trời vỡ làm hai nửa\r\nNếu mà anh không tới, thì cả đời đâu còn ai sửa\r\nĐóm lửa đỏ trên đầu thuốc rơi vào gạt tàn như thể sao băng\r\nHồn anh như lạc đàn ở giữa bạt ngàn góc rễ bao quanh\r\nXin lỗi vì lòng hơi say, trong đầu thì đầy chếnh choáng\r\nCảm ơn những nỗi buồn vì đã đưa đôi chân này đến quán\r\nAnh biết là nếu đêm tàn sẽ kéo thêm ngàn suy nghĩ miên man\r\nNên là, vui đi, để tim mình liên hoang\r\n\r\nNgười khép đôi hàng mi không sầu vương đang nhìn tôi\r\nNgười khiến tôi nhận ra tôi chỉ yêu em mà thôi\r\nSau bao dối gian trong đời\r\nYêu đương hoá ra không lời nên\r\nCòn có bao người mong cho tình yêu kia thành phim\r\nVà có bao người đau nên buộc con tim lặng im\r\nRiêng tôi sẽ luôn yêu người\r\nNhư tôi đã luôn yêu người\r\nTừ đầu...");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "The Lazy Song":
                    {
                        Playlist.Rows.Add("EN", Properties.Resources.The_Lazy_Song, 0, "The Lazy Song", "Bruno Mars", "3:28", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Bruno Mars - The Lazy Song.wav", "Today I don't feel like doing anything\r\nI just wanna lay in my bed\r\nDon't feel like picking up my phone\r\nSo leave a message at the tone\r\n'Cause today I swear I'm not doing anything\r\nUh, I'm gonna kick my feet up then stare at the fan\r\nTurn the TV on, throw my hand in my pants\r\nNobody's gon' tell me I can't, nah\r\nI'll be lounging on the couch, just chilling in my Snuggie\r\nClick to MTV so they can teach me how to dougie\r\n'Cause in my castle I'm the freaking man\r\nOh, yes, I said it, I said it, I said it 'cause I can\r\nToday I don't feel like doing anything\r\nI just wanna lay in my bed\r\nDon't feel like picking up my phone\r\nSo leave a message at the tone\r\n'Cause today I swear I'm not doing anything\r\nNothing at all\r\nWoo-ooh, woo-ooh, ooh\r\nNothing at all\r\nWoo-ooh, woo-ooh, ooh\r\nTomorrow I'll wake up, do some P90X\r\nMeet a really nice girl, have some really nice sex\r\nAnd she's gonna scream out, \"This is great\" (oh, my God, this is great), yeah\r\nI might mess around and get my college degree\r\nI bet my old man will be so proud of me\r\nBut sorry pops, you'll just have to wait\r\nOh, yes, I said it, I said it, I said it 'cause I can\r\nToday I don't feel like doing anything\r\nI just wanna lay in my bed\r\nDon't feel like picking up my phone\r\nSo leave a message at the tone\r\n'Cause today I swear I'm not doing anything\r\nNo, I ain't gonna comb my hair\r\n'Cause I ain't going anywhere\r\nNo, no, no, no, no, no, no, no, no, oh\r\nI'll just strut in my birthday suit\r\nAnd let everything hang loose\r\nYeah, yeah, yeah, yeah, yeah, yeah, yeah, yeah, yeah, yeah\r\nOh, today I don't feel like doing anything\r\nI just wanna lay in my bed\r\nDon't feel like picking up my phone\r\nSo leave a message at the tone\r\n'Cause today I swear I'm not doing anything\r\nNothing at all\r\nWoo-ooh, woo-ooh, ooh\r\nNothing at all\r\nWoo-ooh, woo-ooh, ooh\r\nNothing at all");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Heat Waves":
                    {
                        Playlist.Rows.Add("EN", Properties.Resources.Heat_Waves, 0, "Heat Waves", "Glass Animals", "3:55", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Glass Animals - Heat Waves.wav", "Road shimmer\r\nWiggling the vision\r\nHeat heat waves\r\nI'm swimming in a mirror\r\nRoad shimmer\r\nWiggling the vision\r\nHeat heat waves\r\nI'm swimming in a\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nUsually I put\r\nSomething on TV\r\nSo we never think\r\nAbout you and me\r\nBut today I see\r\nOur reflections\r\nClearly in Hollywood\r\nLaying on the screen\r\nYou just need a better life than this\r\nYou need something I can never give\r\nFake water all across the road\r\nIt's gone now, the night has come, but\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nYou can't fight it\r\nYou can't breathe\r\nYou say something so loving, but\r\nNow I've got to let you go\r\nYou'll be better off in someone new\r\nI don't wanna be alone\r\nYou know it hurts me too\r\nYou look so broken when you cry\r\nOne more and then I'll say goodbye\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nI just wonder what you're dreaming of\r\nWhen you sleep and smile so comfortable\r\nI just wish that I could give you that\r\nThat look that's perfectly un-sad\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nHeat waves been faking me out\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nSometimes, all I think about is you\r\nLate nights in the middle of June\r\nHeat waves been faking me out\r\nCan't make you happier now\r\nRoad shimmer\r\nWiggling the vision\r\nHeat heat waves\r\nI'm swimming in a mirror\r\nRoad shimmer\r\nWiggling the vision\r\nHeat heat waves\r\nI'm swimming in a mirror");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Head In The Cloud":
                    {
                        Playlist.Rows.Add("EN", Properties.Resources.Head_In_The_Cloud, 0, "Head In The Cloud", "Hayd", "3:07", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Hayd - Head In The Clouds.wav", "I miss the days when life was so simple\r\nFelt like the glass was always half full\r\nWhere did that go?\r\nAnd every second with you was so special\r\nBack when we didn't fear the unknowns\r\nBut that was long ago\r\nWho can say where the path will go?\r\nPhilosophers guess but they just don't know\r\nMaybe that's why\r\nWe had our head in the clouds\r\nThought we had it all figured out\r\nPlanning to fly away\r\nTo escape everything on the ground\r\nBut like a plane up in space\r\nWe slowly drifted away\r\nAnd every plan that we made\r\nAnd dream that we chased\r\nAre just memories now\r\nThey're just memories now\r\nI'm not sure where everything went wrong\r\nBut I know that we landed where we both belong\r\n(Where we both belong)\r\nI just wish we weren't scared to say\r\nThat there's expiration dates on the friends you make\r\nAs hard as that may sound\r\nWho can say where the path will go?\r\nPhilosophers guess but they just don't know\r\nMaybe that's why\r\nWe had our head in the clouds\r\nThought we had it all figured out\r\nPlanning to fly away\r\nTo escape everything on the ground\r\nBut like a plane up in space\r\nWe slowly drifted away\r\nAnd every plan that we made\r\nAnd dream that we chased\r\nAre just memories now\r\nThey're just memories now\r\nWho can say where the path will go?\r\n(Where the path will go? Where the path will go?)\r\nPhilosophers guess but they just don't know\r\n(But they just don't know)\r\n");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "comethru":
                    {
                        Playlist.Rows.Add("EN", Properties.Resources.Comethru, 0, "comethru", "Jeremy Zucker", "3:00", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Jeremy Zucker - comethru.wav", "I might lose my mind\r\nWaking when the sun's down\r\nRiding all these highs\r\nWaiting for the comedown\r\nWalk these streets with me\r\nI'm doing decently\r\nJust glad that I can breathe, yeah\r\nI'm trying to realize\r\nIt's alright to not be fine on your own\r\nNow I'm shaking, drinking all this coffee\r\nThese last few weeks have been exhausting\r\nI'm lost in my imagination\r\nAnd there's one thing that I need from you\r\nCan you come through, through?\r\nThrough, yeah\r\nAnd there's one thing that I need from you\r\nCan you come through?\r\nAin't got much to do\r\nToo old for my hometown\r\nWent to bed at noon\r\nCouldn't put my phone down\r\nScrolling patiently\r\nIt's all the same to me\r\nJust faces on a screen, yeah\r\nI'm trying to realize\r\nIt's alright to not be fine on your own\r\nNow I'm shaking, drinking all this coffee\r\nThese last few weeks have been exhausting\r\nI'm lost in my imagination\r\nAnd there's one thing that I need from you\r\nCan you come through, through?\r\nThrough, yeah\r\nAnd there's one thing that I need from you\r\nCan you come\r\nThrough, through\r\nThrough, yeah\r\nAnd there's one thing that I need from you\r\nCan you come through?");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Paris in the Rain":
                    {
                        Playlist.Rows.Add("EN", Properties.Resources.Paris_In_The_Rain, 0, "Paris in the Rain", "Lauv", "3:36", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Lauv - Paris in the Rain.wav", "All I know is (ooh ooh ooh)\r\nWe could go anywhere, we could do\r\nAnything, girl, whatever the mood we're in\r\nYeah all I know is (ooh ooh ooh)\r\nGetting lost late at night, under stars\r\nFinding love standing right where we are, your lips\r\nThey pull me in the moment\r\nYou and I alone and\r\nPeople may be watching, I don't mind\r\n'Cause anywhere with you feels right\r\nAnywhere with you feels like\r\nParis in the rain\r\nParis in the rain\r\nWe don't need a fancy town\r\nOr bottles that we can't pronounce\r\n'Cause anywhere, babe\r\nIs like Paris in the rain\r\nWhen I'm with you ooh ooh ooh\r\nWhen I'm with you ooh ooh ooh\r\nParis in the rain\r\nParis in the rain\r\nI look at you now and I want this forever\r\nI might not deserve it but there's nothing better\r\nDon't know how I ever did it all without you\r\nMy heart is about to, about to jump out of my chest\r\nFeelings they come and they go, that they do\r\nFeelings they come and they go, not with you\r\nThe late nights\r\nAnd the street lights\r\nAnd the people\r\nLook at me girl\r\nAnd the whole world could stop\r\nAnywhere with you feels right\r\nAnywhere with you feels like\r\nParis in the rain\r\nParis in the rain\r\nWe don't need a fancy town\r\nOr bottles that we can't pronounce\r\n'Cause anywhere, babe\r\nIs like Paris in the rain\r\nWhen I'm with you ooh ooh\r\nWhen I'm with you ooh ooh\r\nParis in the rain\r\nParis in the rain\r\nOh\r\nGirl, when I'm not with you\r\nAll I do is miss you\r\nSo come and set the mood right\r\nUnderneath the moonlight\r\n(Days in Paris\r\nNights in Paris)\r\nPaint you with my eyes closed\r\nWonder where the time goes\r\n(Yeah, isn't it obvious?\r\nIsn't it obvious?)\r\nSo come and set the mood right\r\nUnderneath the moonlight\r\n'Cause anywhere with you feels right\r\nAnywhere with you feels like\r\nParis in the rain\r\nParis in the rain\r\nWalking down an empty street\r\nPuddles underneath our feet");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Rude":
                    {
                        Playlist.Rows.Add("EN", Properties.Resources.Rude, 0, "Rude", "MAGIC!", "3:45", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG MAGIC - Rude.wav", "Saturday mornin', jumped out of bed\r\nAnd put on my best suit\r\nGot in my car and raced like a jet\r\nAll the way to you\r\nKnocked on your door with heart in my hand\r\nTo ask you a question\r\n'Cause I know that you're an old fashioned man\r\nYeah (yeah)\r\nCan I have your daughter for the rest of my life?\r\nSay yes, say yes, 'cause I need to know\r\nYou say I'll never get your blessin' 'til the day I die\r\n\"Tough luck, my friend, but the answer is no\"\r\nWhy you gotta be so rude?\r\nDon't you know I'm human too?\r\nWhy you gotta be so rude?\r\nI'm gonna marry her anyway\r\n(Marry that girl) marry her anyway\r\n(Marry that girl) yeah, no matter what you say\r\n(Marry that girl) and we'll be a family\r\nWhy you gotta be so rude?\r\nI hate to do this, you leave no choice\r\nCan't live without her\r\nLove me or hate me, we will be both\r\nStandin' at that alter\r\nOr we will run away\r\nTo another galaxy, you know\r\nYou know she's in love with me\r\nShe will go anywhere I go\r\nCan I have your daughter for the rest of my life?\r\nSay yes, say yes, 'cause I need to know\r\nYou say I'll never get your blessin' 'tll the day I die\r\n\"Tough luck, my friend, 'cause the answer's still no\"\r\nWhy you gotta be so rude?\r\nDon't you know I'm human too?\r\nWhy you gotta be so rude?\r\nI'm gonna marry her anyway\r\n(Marry that girl) marry her anyway\r\n(Marry that girl) no matter what you say\r\n(Marry that girl) and we'll be a family\r\nWhy you gotta be so rude?\r\nRude\r\nCan I have your daughter for the rest of my life?\r\nSay yes, say yes, 'cause I need to know\r\nYou say I'll never get your blessin' 'til the day I die\r\n\"Tough luck, my friend, but no still means no\"\r\nWhy you gotta be so rude?\r\nDon't you know I'm human too?\r\nWhy you gotta be so rude?\r\nI'm gonna marry her anyway\r\n(Marry that girl) marry her anyway\r\n(Marry that girl) no matter what you say\r\n(Marry that girl) and we'll be a family\r\nWhy you gotta be so rude?\r\nOh, yeah, oh\r\nWhy you gotta be so rude?\r\nWhy? (Yeah)\r\nWhy you gotta be so rude?");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "When I Grow Up":
                    {
                        Playlist.Rows.Add("EN", Properties.Resources.When_I_Grow_Up, 0, "When I Grow Up", "NF", "4:00", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG NF - When I Grow Up.wav", "[Verse 1]\r\nYeah, when I grow up, you know what I wanna be?\r\nTake a seat, let me tell you my ridiculous dreams\r\nI wanna rap, yeah, I know it's hard to believe\r\nAnd I can tell you're already thinkin' I will never succeed\r\nBut I'm okay with it, I admit the lyrics are weak\r\nI've been workin' on 'em, I'll be good eventually\r\nI understand you gotta crawl before you get to your feet\r\nBut I been running for a while, they ain't ready for me, ahh\r\nI know this prolly isn't really realistic\r\nAnd honestly, I might not ever make a difference\r\nBut that don't make a difference, I'ma have to risk it\r\nI've been crunchin' numbers, you ain't gotta be a mathematician\r\nTo see the odds ain't rootin' for me\r\nI can't lie though, it's kinda how I like it to be\r\nThe underdog, yeah, you prolly think you know what I mean\r\nBut what I'm saying is they ever push me, I'm gonna swing, yeah\r\nI could go to college, get in debt like everybody else\r\nGraduate and prolly get a job that doesn't pay the bills\r\nThat don't make a lot of sense to me, forget the Happy Meals\r\nI don't like the dollar menu, I would rather make a meal\r\nHuh? Make a mil'? Nah, I said make a meal\r\nHome-cookin', get the grill, how you want it? Pretty well?\r\nEverything I see is overdone to me, I'm not Adele\r\nBut I'ma get a record deal and say hello to mass appeal\r\nYou might also like\r\nThe Search\r\nNF\r\nLie\r\nNF\r\nTime\r\nNF\r\n[Chorus]\r\nWhen I grow up, I just want to pay my bills\r\nRappin' about the way I feel (Oh, yeah)\r\nI just want to make a couple mil'\r\nLeave it to the fam in the will (Oh, yeah)\r\nI just want to sign a record deal\r\nMaybe buy a house up in the hills (Oh, yeah)\r\nMight not be the best in my field\r\nBut I guarantee that I'ma die real\r\nWhen I grow up\r\n\r\n[Post-Chorus]\r\nYeah, ayy\r\nWhen I grow up\r\nYeah, yeah, ayy\r\n\r\n[Verse 2]\r\nI'ma make 'em notice me, rhymin' like it's poetry\r\nEverything I oversee, I just like to overthink\r\nMockin' me, you pay the fee, no return and no receipts\r\nThose of you that don't believe, quiet, you don't know a thing\r\nQuiet when I'm tryna sing, quiet when I'm making beats\r\nQuiet when I'm tryna think, sorry, I don't mean to scream\r\nI just feel like no one really gets me and it's sad to see\r\n'Cause someday I'ma grow up and show all of you it's meant to be (Yeah)\r\nAnybody wanna hear me rap? \"No\"\r\nCome on, let me play a couple tracks, \"No\"\r\nCome on, I can spit it really fast, \"No\"\r\nYou think I should throw this in the trash? \"No\"\r\nTricked ya; haters, go away before I hit ya\r\nI am not a beggar or a kiss-up\r\nYou don't understand? Well, I forgive ya\r\nI am not a quitter, you ain't really think that, did ya?\r\nMaybe someday I could even be up on the radio\r\nHave a tour bus and maybe even play a couple shows\r\nEverybody in the crowd singing every word I wrote\r\nTellin' me that I am not the only one that feels alone\r\nHuh? You feel alone? Yeah, I kinda feel alone\r\nWonder if that feelin' ever goes away when you get old\r\nWill I ever make it as an artist? I don't really know\r\nMight not make a lot of dough\r\nI'ma have to try it, though\r\n[Chorus]\r\nWhen I grow up\r\nI just wanna pay my bills\r\nRappin' about the way I feel (Oh, yeah)\r\nI just wanna make a couple mil'\r\nLeave it to the fam in the will (Oh, yeah)\r\n(Leave it to the fam in the will)\r\n(Yeah, yeah, yeah, yeah)\r\nI just wanna sign a record deal\r\nMaybe buy a house up in the hills (Okay, oh, yeah)\r\nMight not be the best in my field (Ayy, ayy, yeah)\r\nBut I guarantee that I'ma die real\r\nWhen I grow up\r\nI just wanna pay my bills (Woo)\r\nRappin' about the way I feel (Oh, yeah)\r\n(Yeah, the way I feel)\r\nYeah, I just wanna make a couple mil' (Ayy, couple mil')\r\nLeave it to the fam in the will (Oh, yeah, to the fam in the will)\r\nI just wanna sign a record deal (Woo)\r\nMaybe buy a house up in the hills (Oh, yeah)\r\n(House up in the hills)\r\nYeah, I might not be the best in my field\r\nBut I guarantee that I'ma die real\r\nWhen I grow up\r\nWhen I grow up");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Counting Stars":
                    {
                        Playlist.Rows.Add("EN", Properties.Resources.Counting_Stars, 0, "Counting Stars", "OneRepublic", "4:43", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG OneRepublic - Counting Stars.wav", "Lately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be counting stars\"\r\nYeah, we'll be counting stars\r\nI see this life, like a swinging vine\r\nSwing my heart across the line\r\nAnd in my face is flashing signs\r\nSeek it out and ye shall find\r\nOld, but I'm not that old\r\nYoung, but I'm not that bold\r\nAnd I don't think the world is sold\r\nOn just doing what we're told\r\nI feel something so right\r\nDoing the wrong thing\r\nAnd I feel something so wrong\r\nDoing the right thing\r\nI couldn't lie, couldn't lie, couldn't lie\r\nEverything that kills me makes me feel alive\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be counting stars\"\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be, we'll be counting stars\"\r\nYeah, yeah\r\nI feel your love, and I feel it burn\r\nDown this river, every turn\r\nHope is our four-letter word\r\nMake that money, watch it burn\r\nOld, but I'm not that old\r\nYoung, but I'm not that bold\r\nAnd I don't think the world is sold\r\nOn just doing what we're told\r\nAnd I feel something so wrong\r\nDoing the right thing\r\nI couldn't lie, couldn't lie, couldn't lie\r\nEverything that drowns me makes me wanna fly\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be counting stars\"\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be, we'll be counting stars\"\r\nOh, take that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nEverything that kills me makes me feel alive\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be counting stars\"\r\nLately, I've been, I've been losing sleep\r\nDreaming about the things that we could be\r\nBut baby, I've been, I've been praying hard\r\nSaid, \"No more counting dollars, we'll be, we'll be counting stars\"\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned\r\nTake that money, watch it burn\r\nSink in the river the lessons I've learned");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "death bed":
                    {
                        Playlist.Rows.Add("EN", Properties.Resources.Deathbed, 0, "death bed", "Powfu", "2:53", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG Powfu - death bed.wav", "Don't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed\r\nYeah, I don't wanna fall asleep, I don't wanna pass away\r\nI been thinking of our future, 'cause I'll never see those days\r\nI don't know why this has happened, but I probably deserve it\r\nI tried to do my best, but you know that I'm not perfect\r\nI been praying for forgiveness, you've been praying for my health\r\nWhen I leave this Earth, hoping you'll find someone else\r\n'Cause, yeah, we still young, there's so much we haven't done\r\nGetting married, start a family, watch your husband with his son\r\nI wish it could be me, but I won't make it out this bed\r\nI hope I go to Heaven, so I see you once again\r\nMy life was kinda short, but I got so many blessings\r\nHappy you were mine, it sucks that it's all ending\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed (yeah, ayy, ayy)\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed (ayy, yeah)\r\nI'm happy that you here with me, I'm sorry if I tear up\r\nWhen me and you were younger, you would always make me cheer up\r\nTaking goofy videos and walking through the park\r\nYou would jump into my arms every time you heard a bark\r\nCuddle in your sheets, sing me sound asleep\r\nAnd sneak out through your kitchen at exactly 1:03\r\nSundays, went to church, on Mondays, watched a movie\r\nSoon you'll be alone, sorry that you have to lose me\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed\r\nDon't stay awake for too long, don't go to bed\r\nI'll make a cup of coffee for your head\r\nIt'll get you up and going out of bed");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Stressed out":
                    {
                        Playlist.Rows.Add("EN", Properties.Resources.Stressed_Out, 0, "Stressed out", "twenty one pilot", "3:45", " ", "D:\\CS511 C# Language\\music\\musicdemo\\eng\\ENG twenty one pilots - Stressed Out.wav", "I wish I found some better sounds no one's ever heard\r\nI wish I had a better voice that sang some better words\r\nI wish I found some chords in an order that is new\r\nI wish I didn't have to rhyme every time I sang\r\nI was told when I get older, all my fears would shrink\r\nBut now I'm insecure, and I care what people think\r\nMy name's Blurryface and I care what you think\r\nMy name's Blurryface and I care what you think\r\nWish we could turn back time\r\nTo the good old days\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out (oh)\r\nWish we could turn back time (oh)\r\nTo the good old days (oh)\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out\r\nWe're stressed out\r\nSometimes a certain smell will take me back to when I was young\r\nHow come I'm never able to identify where it's coming from?\r\nI'd make a candle out of it if I ever found it\r\nTry to sell it, never sell out of it, I'd probably only sell one\r\nIt'd be to my brother, 'cause we have the same nose\r\nSame clothes, homegrown, a stone's throw from a creek we used to roam\r\nBut it would remind us of when nothing really mattered\r\nOut of student loans and tree house homes, we all would take the latter\r\nMy name's Blurryface and I care what you think\r\nMy name's Blurryface and I care what you think\r\nWish we could turn back time\r\nTo the good old days\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out (oh)\r\nWish we could turn back time (oh)\r\nTo the good old days (oh)\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out\r\nUsed to play pretend, give each other different names\r\nWe would build a rocket ship and then we'd fly it far away\r\nUsed to dream of outer space, but now they're laughing at our face saying\r\n\"Wake up, you need to make money\", yeah\r\nWe used to play pretend, give each other different names\r\nWe would build a rocket ship and then we'd fly it far away\r\nUsed to dream of outer space, but now they're laughing at our face saying\r\n\"Wake up, you need to make money\", yeah\r\nWish we could turn back time\r\nTo the good old days\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out (oh)\r\nWish we could turn back time (oh)\r\nTo the good old days (oh)\r\nWhen our mama sang us to sleep\r\nBut now we're stressed out\r\nWe used to play pretend, used to play pretend, money\r\nWe used to play pretend, wake up, you need the money\r\nUsed to play pretend, used to play pretend, money\r\nWe used to play pretend, wake up, you need the money\r\nUsed to play pretend, give each other different names\r\nWe would build a rocket ship and then we'd fly it far away\r\nUsed to dream of outer space, but now they're laughing at our face saying\r\n\"Wake up, you need to make money\", yeah");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Heads Will Roll":
                    {
                        Playlist.Rows.Add("EDM", Properties.Resources.Heads_Will_Roll, 0, "Heads Will Roll", "Amfree & Ampris", "2:20", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Amfree & Ampris - Heads Will Roll.wav", "Off with your head\r\nDance til you're dead\r\nHeads will roll\r\nHeads will roll\r\nHeads will roll\r\nOn the floor\r\nGlitter on the wet streets\r\nSilver over everything\r\nThe river's all wet\r\nYou're all chrome\r\nDripping with alchemy\r\nShiver stop shivering\r\nThe glitter's all wet\r\nYou're all chrome\r\nThe men cry out the girls cry out\r\nThe men cry out the girls cry out\r\nThe men cry out, oh no\r\nThe men cry out the girls cry out\r\nThe men cry out the girls cry out\r\nThe men cry out, oh no\r\nOh oh! Oh!\r\nOh oh! Oh!\r\nOff, off with your head\r\nDance, dance til you're dead (dead)\r\nHeads will roll\r\nHeads will roll\r\nHeads will roll\r\nOn the floor\r\nLooking glass\r\nTake the past\r\nShut your eyes\r\nRealize\r\nLooking glass\r\nTake the past\r\nShut your eyes\r\nRealize\r\nGlitter on the wet streets\r\nSilver over everything\r\nThe river's all wet\r\nYou're all chrome\r\nYou're all chrome\r\nOh!\r\nOh oh!\r\nOff, off, off with your head\r\nDance, dance dance til you're dead\r\nOff, off, off with your head\r\nDance, dance, dance til you're dead\r\nOff, off, off with your head\r\nDance, dance, dance til you're dead\r\nOff, off, off with your head\r\nDance, dance, dance til you're dead\r\nOff, off, off with your head\r\nDance, dance, dance til you're dead\r\nOff, off, off with your head\r\nDance, dance, dance til you're dead");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Waiting For Love":
                    {
                        Playlist.Rows.Add("EDM", Properties.Resources.Waiting_For_Love, 0, "Waiting For Love", "Avicii", "3:50", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Avicii - Waiting For Love.wav", "Where there's a will, there's a way, kind of beautiful\r\nAnd every night has its day, so magical\r\nAnd if there's love in this life, there's no obstacle\r\nThat can't be defeated\r\nFor every tyrant, a tear for the vulnerable\r\nIn every lost soul, the bones of a miracle\r\nFor every dreamer, a dream, we're unstoppable\r\nWith something to believe in\r\nMonday left me broken\r\nTuesday, I was through with hoping\r\nWednesday, my empty arms were open\r\nThursday, waiting for love, waiting for love\r\nThank the stars, it's Friday\r\nI'm burning like a fire gone wild on Saturday\r\nGuess I won't be coming to church on Sunday\r\nI'll be waiting for love, waiting for love to come around\r\nWe are one of a kind, irreplaceable\r\nHow did I get so blind and so cynical?\r\nIf there's love in this life, we're unstoppable\r\nNo, we can't be defeated\r\nMonday left me broken\r\nTuesday, I was through with hoping\r\nWednesday, my empty arms were open\r\nThursday, waiting for love, waiting for love\r\nThank the stars, it's Friday\r\nI'm burning like a fire gone wild on Saturday\r\nGuess I won't be coming to church on Sunday\r\nI'll be waiting for love, waiting for love to come around");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "If Only I Could":
                    {
                        Playlist.Rows.Add("EDM", Properties.Resources.If_Only_I_Could, 0, "If Only I Could", "Brooks", "4:22", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Brooks - If Only I Could.wav", "Stronger than a brick house\r\nBigger than the moon and brighter than the stars\r\nIf I could move the mountains\r\nI would've known who you are\r\n'Cause I've been lookin' far a way to get lost in your eyes\r\nTryna find my way in this chaos\r\nIf I could walk on water\r\nI could've known who you are\r\nIf only I could be the one to say\r\nYou can't stop me now\r\n'Cause I've been lookin' for...\r\n'Cause I've been lookin' for...\r\nIf I'd shown you what I'm made of\r\nYou would've seen it into me\r\nIf I'd shown you what I'm made of\r\nMaybe you'll see into me\r\nFaster than a race car\r\nSharper than a knife and higher than the trees\r\nIf I'd shown you what I'm made of\r\nYou would've seen it into me\r\n'Cause I've been lookin' for a way to get lost in your eyes\r\nTryna find my way in this chaos\r\nIf I show you what I'm made of\r\nMaybe you'll see into me, to me\r\nYou're fallin'\r\nIf only I could be the one to say\r\nIf only I could be the one to say\r\nYou can't stop me now\r\n'Cause I've been lookin' for...\r\n'Cause I've been lookin' for...\r\nIf I'd shown you what I'm made of\r\nYou would've seen into me\r\nIf I'd shown you what I'm made of\r\nMaybe you'll see into me");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Journey":
                    {
                        Playlist.Rows.Add("EDM", Properties.Resources.Journey, 0, "Journey", "Don Diablo", "3:13", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Don Diablo - Journey.wav", "Take me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me where you wanna go, go, go\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me where you wanna go, go, go\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go\r\nTake me where you wanna\r\nTake me where you wanna\r\nTake me where you wanna go, go, go");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Where Are You Now":
                    {
                        Playlist.Rows.Add("EDM", Properties.Resources.Where_Are_You_Now, 0, "Where Are You Now", "Lost Frequencies", "2:53", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Lost Frequencies - Where Are You Now.wav", "You're just like my favorite song going 'round and 'round my head\r\nLike my favorite song going 'round and 'round my head\r\nFive days on the freeway\r\nRiding shotgun with you (yeah, yeah)\r\nTwo hearts in the fast lane\r\nWe had big dreams in blue (yeah, yeah)\r\nPlaying Sweet Child O' Mine\r\nAnd I still feel that line\r\nWhere are you now?\r\nWhere are you now?\r\nHey, it's been too long\r\nToo long to go, my love\r\nWhere did we go wrong?\r\nToo late to turn around\r\nWhere are you now?\r\nWhere are you now?\r\nHey, it's been too long\r\nYou're just like my favorite song going 'round and 'round my head\r\nLike my favorite song going 'round and 'round my head\r\nYou're just like my favorite song going 'round and 'round my head\r\nLike my favorite song going 'round and 'round my head\r\nHey, it's been too long\r\nSome days I can feel it\r\nBut the feeling ain't all blue\r\nYou got me believing\r\nOne day you gotta come through\r\nLost in these city lights\r\n'Cause I can't sleep tonight\r\nWhere are you now?\r\nWhere are you now?\r\nHey, it's been too long\r\nToo long to go, my love\r\nWhere did we go wrong?\r\nToo late to turn around\r\nWhere are you now?\r\nWhere are you now?\r\nHey, it's been too long\r\nYou're just like my favorite song going 'round and 'round my head\r\nLike my favorite song going 'round and 'round my head\r\nYou're just like my favorite song going 'round and 'round my head\r\nLike my favorite song going 'round and 'round my head\r\nWhere are you now?\r\nWhere are you now?\r\nWhere are you now?\r\nWhere are you now?\r\nWhere are you now?");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Silence":
                    {
                        Playlist.Rows.Add("EDM", Properties.Resources.Silence, 0, "Silence", "Marshmallow", "3:06", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Marshmello - Silence.wav", "Yeah, I'd rather be a lover than a fighter (fighter)\r\n'Cause all my life, I've been fighting\r\nNever felt a feeling of comfort, oh\r\nAnd all this time, I've been hiding\r\nAnd I never had someone to call my own, oh nah\r\nI'm so used to sharing\r\nLove only left me alone\r\nBut I'm at one with the silence\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been quiet for too long\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been silent for too long\r\nI've been quiet for too long\r\nI've been quiet for too long\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been quiet for too long\r\nI'm in need of a savior (savior), but I'm not asking for favors\r\nMy whole life, I've felt like a burden\r\nI think too much, and I hate it\r\nI'm so used to being in the wrong, I'm tired of caring\r\nLoving never gave me a home, so I'll sit here in the silence\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been quiet for too long\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been silent for too long\r\nI've been quiet for too long\r\nI've been quiet for too long\r\nI found peace in your violence\r\nCan't show me, there's no point in trying\r\nI'm at one, and I've been quiet for too long");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Leyla":
                    {
                        Playlist.Rows.Add("EDM", Properties.Resources.Leyla, 0, "Leyla", "Mesto", "3:07", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Mesto - Leyla.wav", "You were only 17\r\nLookin' at your window screen\r\nSweetest girl I've ever seen\r\nStraight up from a project dream\r\nYou were on the second floor\r\nI was right across from yours\r\nTwo different sides of war\r\nKinda like a west side story, now\r\nLeyla, I am in love with you, Leyla\r\nI'm comin' up any day now\r\nSo bust that window and come with me\r\nLeyla, get all your stuff and we'll break out\r\nBaby, I know what they'll say now\r\nBut I want you anyway\r\nBut I want you anyway\r\nBut I want you anyway\r\nNow we've turned 23\r\nYou've moved across town from me\r\nOur friends and family, wouldn't let us be happy\r\nI hear you're married now\r\nHear it ain't working out\r\nThey can't shut us down\r\nLeyla just tell me how and I'll be there\r\nYou are a goddess, I want you to know (oh-oh-oh-oh)\r\nI'll never forget you, I'll never let go\r\nYeah, I'll be comin' to get you\r\nLeyla, I am in love with you, Leyla\r\nI'm comin' up any day now\r\nSo bust that window and come with me\r\nLeyla, get all your stuff and we'll break out\r\nBaby, I know what they'll say now\r\nBut I want you anyway\r\nBut I want you anyway\r\nBut I want you anyway\r\nYou are a goddess, I want you to know (oh-oh-oh-oh)\r\nI'll never forget you, I'll never let go\r\nYeah, I'll be comin' to get you\r\nLeyla, I am in love with you, Leyla\r\nI'm comin' up any day now\r\nSo bust that window and come with me\r\nLeyla, get all your stuff and we'll break out\r\nBaby, I know what they'll say now\r\nBut I want you anyway\r\nBut I want you anyway\r\nLeyla, I am in love with you, Leyla\r\nI'm comin' up any day now\r\nSo bust that window and come with me\r\nLeyla, get all your stuff and we'll break out\r\nBaby, I know what they'll say now\r\nBut I want you anyway");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "When The Sun's Gone":
                    {
                        Playlist.Rows.Add("EDM", Properties.Resources.When_The_Suns_Gone, 0, "When The Sun's Gone", "Mike William", "2:58", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Mike Williams - When The Sun Is Gone.wav", "When the sun, when the sun, when the sun is gone\r\nHold me tight when you feel like it all goes wrong\r\nTogether we'll be okay\r\nWe're the light in the world when the sun is gone (Is gone)\r\nWe'll be running red lights till the end of the road\r\nGonna make it, you and I, baby, that I know\r\nBut I'll hold you tight in my arms when the sun is gone (Is gone)\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nHold you tight in my arms when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nHold you tight in my arms when the sun is gone (Is gone)\r\nFollow me, I know we'll find higher ground\r\nAs long as we are together\r\nFind the path through the light where the dusk fades out (fade out)\r\nWe'll be running red lights till the end of the road\r\nGonna make it, you and I, baby, that I know\r\nBut I'll hold you tight in my arms when the sun is gone (Is gone)\r\nWhen the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nHold you tight in my arms when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nWhen the sun, when the sun, when the sun is gone\r\nHold you tight in my arms when the sun is gone\r\n");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Bullet Waiting For Me":
                    {
                        Playlist.Rows.Add("EDM", Properties.Resources.Bullet_Waiting_For_Me, 0, "Bullet Waiting For Me", "Nikki Simmons", "4:51", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM Nikki Simmons - Bullet Waiting For Me.wav", "Standing on the open shore, in a world of disarray\r\n'Cause the chaos is a warm embrace\r\nAs the fire hits my body and my conscience is consumed\r\nNothing left of me but you, yeah\r\nAnd dancin' with my demons through and through\r\nJust stare into the distance for a chance to come around, take it\r\n\r\nThe final destination is at hand and for the first time in forever\r\nI feel the resolution, yeah\r\nThe shoreline keeps a’rising up to me, looking for my revolution\r\nThis is my chance to breathe, yeah-ah-ah-ah!\r\n\r\nLooking on the edge of fantasy; It’s a crashing wall of thunder\r\nAnd the roar of what I wish to believe is the bullet waiting for me\r\n\r\nLooking on the edge of fantasy; It’s a crashing wall of thunder\r\nAnd the roar of what I wish to believe is the bullet waiting for me");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case "Roses":
                    {
                        Playlist.Rows.Add("EDM", Properties.Resources.Roses, 0, "Roses", "The Chainsmokers", "3:50", " ", "D:\\CS511 C# Language\\music\\musicdemo\\edm\\EDM The Chainsmokers - Roses.wav", "You brought one to my door\r\nStood there on the front porch\r\nThat was the beginning\r\nWe had those tires spinning\r\nDown to the green grass\r\nOutside of town\r\nWild and free, never slowing down\r\nI thought I needed you like air\r\nWe burned hot, burned out, like a flame\r\nBut in my head, you'll never fade\r\nYeah, we were classic\r\nMy dress, your leather jacket\r\nDidn't know how good we had it\r\nBut, boy, we had it\r\n14th of February, gotta feeling my heart still carries\r\nYeah, we didn't know it\r\nThought we could grow it\r\nBeautiful for a moment\r\nWe were roses\r\nWe were roses\r\nYou put one in my hair\r\nWe danced in the middle of nowhere\r\nYou and me all summer\r\nBright and living color\r\nMy lips were red\r\nYour eyes were blue\r\nAnd I thought I saw forever in you\r\nYeah, we were classic\r\nMy dress, your leather jacket\r\nDidn't know how good we had it\r\nBut, boy, we had it\r\n14th of February, gotta feeling my heart still carries\r\nYeah, we didn't know it\r\nThought we could grow it\r\nBeautiful for a moment\r\nWe were roses\r\nBut seasons had to change\r\nAnd like flowers they bloom and withered away\r\nYeah, we were classic\r\nMy dress, your leather jacket\r\nDidn't know how good we had it\r\nIt was so good while it lasted\r\nYeah, we were classic\r\nMy dress, your leather jacket\r\nDidn't know how good we had it\r\nBut, boy, we had it\r\n14th of February, gotta feeling my heart still carries\r\nYeah, we didn't know it\r\nThought we could grow it\r\nBeautiful for a moment\r\nWe were roses\r\nWe were beautiful for a moment, baby\r\nWe were roses\r\nWe were beautiful for a moment, baby\r\nWe didn't know it\r\nThought we could grow it\r\nBeautiful for a moment\r\nWe were roses");

                        j++;
                        MessageBox.Show("Song added to My Playlist", "Changed in My Playlist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            flagvn = 0;
            flagen = 0;
            flagedm = 0;

            panelPlaylist.Visible = true;
            panelInfo.Visible = false;
            panelLiked.Visible = false;
            labelPlaylistCount.Text = (j + 1).ToString();

            switch (j)
            {
                case -1:
                    panelPlaylist1.Visible = false;
                    panelPlaylist2.Visible = false;
                    panelPlaylist3.Visible = false;
                    panelPlaylist4.Visible = false;
                    panelPlaylist5.Visible = false;
                    panelPlaylist6.Visible = false;
                    panelPlaylist7.Visible = false;
                    panelPlaylist8.Visible = false;
                    panelPlaylist9.Visible = false;
                    panelPlaylist10.Visible = false;
                    break;
                case 0:
                    panelPlaylist1.Visible = true;
                    panelPlaylist2.Visible = false;
                    panelPlaylist3.Visible = false;
                    panelPlaylist4.Visible = false;
                    panelPlaylist5.Visible = false;
                    panelPlaylist6.Visible = false;
                    panelPlaylist7.Visible = false;
                    panelPlaylist8.Visible = false;
                    panelPlaylist9.Visible = false;
                    panelPlaylist10.Visible = false;

                    picPlaylist1.BackgroundImage = (Image)Playlist.Rows[0]["hinhanh"];
                    labelPlaylist1.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist3.Text = Playlist.Rows[0]["tencasi"].ToString();
                    labelPlaylist2.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist4.Text = Playlist.Rows[0]["thoiluong"].ToString();
                    break;
                case 1:
                    panelPlaylist1.Visible = true;
                    panelPlaylist2.Visible = true;
                    panelPlaylist3.Visible = false;
                    panelPlaylist4.Visible = false;
                    panelPlaylist5.Visible = false;
                    panelPlaylist6.Visible = false;
                    panelPlaylist7.Visible = false;
                    panelPlaylist8.Visible = false;
                    panelPlaylist9.Visible = false;
                    panelPlaylist10.Visible = false;

                    picPlaylist1.BackgroundImage = (Image)Playlist.Rows[0]["hinhanh"];
                    labelPlaylist1.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist3.Text = Playlist.Rows[0]["tencasi"].ToString();
                    labelPlaylist2.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist4.Text = Playlist.Rows[0]["thoiluong"].ToString();

                    picPlaylist2.BackgroundImage = (Image)Playlist.Rows[1]["hinhanh"];
                    labelPlaylist5.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist7.Text = Playlist.Rows[1]["tencasi"].ToString();
                    labelPlaylist6.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist8.Text = Playlist.Rows[1]["thoiluong"].ToString();
                    break;
                case 2:
                    panelPlaylist1.Visible = true;
                    panelPlaylist2.Visible = true;
                    panelPlaylist3.Visible = true;
                    panelPlaylist4.Visible = false;
                    panelPlaylist5.Visible = false;
                    panelPlaylist6.Visible = false;
                    panelPlaylist7.Visible = false;
                    panelPlaylist8.Visible = false;
                    panelPlaylist9.Visible = false;
                    panelPlaylist10.Visible = false;

                    picPlaylist1.BackgroundImage = (Image)Playlist.Rows[0]["hinhanh"];
                    labelPlaylist1.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist3.Text = Playlist.Rows[0]["tencasi"].ToString();
                    labelPlaylist2.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist4.Text = Playlist.Rows[0]["thoiluong"].ToString();

                    picPlaylist2.BackgroundImage = (Image)Playlist.Rows[1]["hinhanh"];
                    labelPlaylist5.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist7.Text = Playlist.Rows[1]["tencasi"].ToString();
                    labelPlaylist6.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist8.Text = Playlist.Rows[1]["thoiluong"].ToString();

                    picPlaylist3.BackgroundImage = (Image)Playlist.Rows[2]["hinhanh"];
                    labelPlaylist9.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist11.Text = Playlist.Rows[2]["tencasi"].ToString();
                    labelPlaylist10.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist12.Text = Playlist.Rows[2]["thoiluong"].ToString();
                    break;
                case 3:
                    panelPlaylist1.Visible = true;
                    panelPlaylist2.Visible = true;
                    panelPlaylist3.Visible = true;
                    panelPlaylist4.Visible = true;
                    panelPlaylist5.Visible = false;
                    panelPlaylist6.Visible = false;
                    panelPlaylist7.Visible = false;
                    panelPlaylist8.Visible = false;
                    panelPlaylist9.Visible = false;
                    panelPlaylist10.Visible = false;

                    picPlaylist1.BackgroundImage = (Image)Playlist.Rows[0]["hinhanh"];
                    labelPlaylist1.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist3.Text = Playlist.Rows[0]["tencasi"].ToString();
                    labelPlaylist2.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist4.Text = Playlist.Rows[0]["thoiluong"].ToString();

                    picPlaylist2.BackgroundImage = (Image)Playlist.Rows[1]["hinhanh"];
                    labelPlaylist5.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist7.Text = Playlist.Rows[1]["tencasi"].ToString();
                    labelPlaylist6.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist8.Text = Playlist.Rows[1]["thoiluong"].ToString();

                    picPlaylist3.BackgroundImage = (Image)Playlist.Rows[2]["hinhanh"];
                    labelPlaylist9.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist11.Text = Playlist.Rows[2]["tencasi"].ToString();
                    labelPlaylist10.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist12.Text = Playlist.Rows[2]["thoiluong"].ToString();

                    picPlaylist4.BackgroundImage = (Image)Playlist.Rows[3]["hinhanh"];
                    labelPlaylist13.Text = Playlist.Rows[3]["tenbaihat"].ToString();
                    labelPlaylist15.Text = Playlist.Rows[3]["tencasi"].ToString();
                    labelPlaylist14.Text = Playlist.Rows[3]["tenbaihat"].ToString();
                    labelPlaylist16.Text = Playlist.Rows[3]["thoiluong"].ToString();
                    break;
                case 4:
                    panelPlaylist1.Visible = true;
                    panelPlaylist2.Visible = true;
                    panelPlaylist3.Visible = true;
                    panelPlaylist4.Visible = true;
                    panelPlaylist5.Visible = true;
                    panelPlaylist6.Visible = false;
                    panelPlaylist7.Visible = false;
                    panelPlaylist8.Visible = false;
                    panelPlaylist9.Visible = false;
                    panelPlaylist10.Visible = false;

                    picPlaylist1.BackgroundImage = (Image)Playlist.Rows[0]["hinhanh"];
                    labelPlaylist1.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist3.Text = Playlist.Rows[0]["tencasi"].ToString();
                    labelPlaylist2.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist4.Text = Playlist.Rows[0]["thoiluong"].ToString();

                    picPlaylist2.BackgroundImage = (Image)Playlist.Rows[1]["hinhanh"];
                    labelPlaylist5.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist7.Text = Playlist.Rows[1]["tencasi"].ToString();
                    labelPlaylist6.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist8.Text = Playlist.Rows[1]["thoiluong"].ToString();

                    picPlaylist3.BackgroundImage = (Image)Playlist.Rows[2]["hinhanh"];
                    labelPlaylist9.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist11.Text = Playlist.Rows[2]["tencasi"].ToString();
                    labelPlaylist10.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist12.Text = Playlist.Rows[2]["thoiluong"].ToString();

                    picPlaylist4.BackgroundImage = (Image)Playlist.Rows[3]["hinhanh"];
                    labelPlaylist13.Text = Playlist.Rows[3]["tenbaihat"].ToString();
                    labelPlaylist15.Text = Playlist.Rows[3]["tencasi"].ToString();
                    labelPlaylist14.Text = Playlist.Rows[3]["tenbaihat"].ToString();
                    labelPlaylist16.Text = Playlist.Rows[3]["thoiluong"].ToString();

                    picPlaylist5.BackgroundImage = (Image)Playlist.Rows[4]["hinhanh"];
                    labelPlaylist17.Text = Playlist.Rows[4]["tenbaihat"].ToString();
                    labelPlaylist19.Text = Playlist.Rows[4]["tencasi"].ToString();
                    labelPlaylist18.Text = Playlist.Rows[4]["tenbaihat"].ToString();
                    labelPlaylist20.Text = Playlist.Rows[4]["thoiluong"].ToString();
                    break;
                case 5:
                    panelPlaylist1.Visible = true;
                    panelPlaylist2.Visible = true;
                    panelPlaylist3.Visible = true;
                    panelPlaylist4.Visible = true;
                    panelPlaylist5.Visible = true;
                    panelPlaylist6.Visible = true;
                    panelPlaylist7.Visible = false;
                    panelPlaylist8.Visible = false;
                    panelPlaylist9.Visible = false;
                    panelPlaylist10.Visible = false;

                    picPlaylist1.BackgroundImage = (Image)Playlist.Rows[0]["hinhanh"];
                    labelPlaylist1.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist3.Text = Playlist.Rows[0]["tencasi"].ToString();
                    labelPlaylist2.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist4.Text = Playlist.Rows[0]["thoiluong"].ToString();

                    picPlaylist2.BackgroundImage = (Image)Playlist.Rows[1]["hinhanh"];
                    labelPlaylist5.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist7.Text = Playlist.Rows[1]["tencasi"].ToString();
                    labelPlaylist6.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist8.Text = Playlist.Rows[1]["thoiluong"].ToString();

                    picPlaylist3.BackgroundImage = (Image)Playlist.Rows[2]["hinhanh"];
                    labelPlaylist9.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist11.Text = Playlist.Rows[2]["tencasi"].ToString();
                    labelPlaylist10.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist12.Text = Playlist.Rows[2]["thoiluong"].ToString();

                    picPlaylist4.BackgroundImage = (Image)Playlist.Rows[3]["hinhanh"];
                    labelPlaylist13.Text = Playlist.Rows[3]["tenbaihat"].ToString();
                    labelPlaylist15.Text = Playlist.Rows[3]["tencasi"].ToString();
                    labelPlaylist14.Text = Playlist.Rows[3]["tenbaihat"].ToString();
                    labelPlaylist16.Text = Playlist.Rows[3]["thoiluong"].ToString();

                    picPlaylist5.BackgroundImage = (Image)Playlist.Rows[4]["hinhanh"];
                    labelPlaylist17.Text = Playlist.Rows[4]["tenbaihat"].ToString();
                    labelPlaylist19.Text = Playlist.Rows[4]["tencasi"].ToString();
                    labelPlaylist18.Text = Playlist.Rows[4]["tenbaihat"].ToString();
                    labelPlaylist20.Text = Playlist.Rows[4]["thoiluong"].ToString();

                    picPlaylist6.BackgroundImage = (Image)Playlist.Rows[5]["hinhanh"];
                    labelPlaylist21.Text = Playlist.Rows[5]["tenbaihat"].ToString();
                    labelPlaylist23.Text = Playlist.Rows[5]["tencasi"].ToString();
                    labelPlaylist22.Text = Playlist.Rows[5]["tenbaihat"].ToString();
                    labelPlaylist24.Text = Playlist.Rows[5]["thoiluong"].ToString();
                    break;
                case 6:
                    panelPlaylist1.Visible = true;
                    panelPlaylist2.Visible = true;
                    panelPlaylist3.Visible = true;
                    panelPlaylist4.Visible = true;
                    panelPlaylist5.Visible = true;
                    panelPlaylist6.Visible = true;
                    panelPlaylist7.Visible = true;
                    panelPlaylist8.Visible = false;
                    panelPlaylist9.Visible = false;
                    panelPlaylist10.Visible = false;

                    picPlaylist1.BackgroundImage = (Image)Playlist.Rows[0]["hinhanh"];
                    labelPlaylist1.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist3.Text = Playlist.Rows[0]["tencasi"].ToString();
                    labelPlaylist2.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist4.Text = Playlist.Rows[0]["thoiluong"].ToString();

                    picPlaylist2.BackgroundImage = (Image)Playlist.Rows[1]["hinhanh"];
                    labelPlaylist5.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist7.Text = Playlist.Rows[1]["tencasi"].ToString();
                    labelPlaylist6.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist8.Text = Playlist.Rows[1]["thoiluong"].ToString();

                    picPlaylist3.BackgroundImage = (Image)Playlist.Rows[2]["hinhanh"];
                    labelPlaylist9.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist11.Text = Playlist.Rows[2]["tencasi"].ToString();
                    labelPlaylist10.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist12.Text = Playlist.Rows[2]["thoiluong"].ToString();

                    picPlaylist4.BackgroundImage = (Image)Playlist.Rows[3]["hinhanh"];
                    labelPlaylist13.Text = Playlist.Rows[3]["tenbaihat"].ToString();
                    labelPlaylist15.Text = Playlist.Rows[3]["tencasi"].ToString();
                    labelPlaylist14.Text = Playlist.Rows[3]["tenbaihat"].ToString();
                    labelPlaylist16.Text = Playlist.Rows[3]["thoiluong"].ToString();

                    picPlaylist5.BackgroundImage = (Image)Playlist.Rows[4]["hinhanh"];
                    labelPlaylist17.Text = Playlist.Rows[4]["tenbaihat"].ToString();
                    labelPlaylist19.Text = Playlist.Rows[4]["tencasi"].ToString();
                    labelPlaylist18.Text = Playlist.Rows[4]["tenbaihat"].ToString();
                    labelPlaylist20.Text = Playlist.Rows[4]["thoiluong"].ToString();

                    picPlaylist6.BackgroundImage = (Image)Playlist.Rows[5]["hinhanh"];
                    labelPlaylist21.Text = Playlist.Rows[5]["tenbaihat"].ToString();
                    labelPlaylist23.Text = Playlist.Rows[5]["tencasi"].ToString();
                    labelPlaylist22.Text = Playlist.Rows[5]["tenbaihat"].ToString();
                    labelPlaylist24.Text = Playlist.Rows[5]["thoiluong"].ToString();

                    picPlaylist7.BackgroundImage = (Image)Playlist.Rows[6]["hinhanh"];
                    labelPlaylist25.Text = Playlist.Rows[6]["tenbaihat"].ToString();
                    labelPlaylist27.Text = Playlist.Rows[6]["tencasi"].ToString();
                    labelPlaylist26.Text = Playlist.Rows[6]["tenbaihat"].ToString();
                    labelPlaylist28.Text = Playlist.Rows[6]["thoiluong"].ToString();
                    break;
                case 7:
                    panelPlaylist1.Visible = true;
                    panelPlaylist2.Visible = true;
                    panelPlaylist3.Visible = true;
                    panelPlaylist4.Visible = true;
                    panelPlaylist5.Visible = true;
                    panelPlaylist6.Visible = true;
                    panelPlaylist7.Visible = true;
                    panelPlaylist8.Visible = true;
                    panelPlaylist9.Visible = false;
                    panelPlaylist10.Visible = false;

                    picPlaylist1.BackgroundImage = (Image)Playlist.Rows[0]["hinhanh"];
                    labelPlaylist1.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist3.Text = Playlist.Rows[0]["tencasi"].ToString();
                    labelPlaylist2.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist4.Text = Playlist.Rows[0]["thoiluong"].ToString();

                    picPlaylist2.BackgroundImage = (Image)Playlist.Rows[1]["hinhanh"];
                    labelPlaylist5.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist7.Text = Playlist.Rows[1]["tencasi"].ToString();
                    labelPlaylist6.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist8.Text = Playlist.Rows[1]["thoiluong"].ToString();

                    picPlaylist3.BackgroundImage = (Image)Playlist.Rows[2]["hinhanh"];
                    labelPlaylist9.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist11.Text = Playlist.Rows[2]["tencasi"].ToString();
                    labelPlaylist10.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist12.Text = Playlist.Rows[2]["thoiluong"].ToString();

                    picPlaylist4.BackgroundImage = (Image)Playlist.Rows[3]["hinhanh"];
                    labelPlaylist13.Text = Playlist.Rows[3]["tenbaihat"].ToString();
                    labelPlaylist15.Text = Playlist.Rows[3]["tencasi"].ToString();
                    labelPlaylist14.Text = Playlist.Rows[3]["tenbaihat"].ToString();
                    labelPlaylist16.Text = Playlist.Rows[3]["thoiluong"].ToString();

                    picPlaylist5.BackgroundImage = (Image)Playlist.Rows[4]["hinhanh"];
                    labelPlaylist17.Text = Playlist.Rows[4]["tenbaihat"].ToString();
                    labelPlaylist19.Text = Playlist.Rows[4]["tencasi"].ToString();
                    labelPlaylist18.Text = Playlist.Rows[4]["tenbaihat"].ToString();
                    labelPlaylist20.Text = Playlist.Rows[4]["thoiluong"].ToString();

                    picPlaylist6.BackgroundImage = (Image)Playlist.Rows[5]["hinhanh"];
                    labelPlaylist21.Text = Playlist.Rows[5]["tenbaihat"].ToString();
                    labelPlaylist23.Text = Playlist.Rows[5]["tencasi"].ToString();
                    labelPlaylist22.Text = Playlist.Rows[5]["tenbaihat"].ToString();
                    labelPlaylist24.Text = Playlist.Rows[5]["thoiluong"].ToString();

                    picPlaylist7.BackgroundImage = (Image)Playlist.Rows[6]["hinhanh"];
                    labelPlaylist25.Text = Playlist.Rows[6]["tenbaihat"].ToString();
                    labelPlaylist27.Text = Playlist.Rows[6]["tencasi"].ToString();
                    labelPlaylist26.Text = Playlist.Rows[6]["tenbaihat"].ToString();
                    labelPlaylist28.Text = Playlist.Rows[6]["thoiluong"].ToString();

                    picPlaylist8.BackgroundImage = (Image)Playlist.Rows[7]["hinhanh"];
                    labelPlaylist29.Text = Playlist.Rows[7]["tenbaihat"].ToString();
                    labelPlaylist31.Text = Playlist.Rows[7]["tencasi"].ToString();
                    labelPlaylist30.Text = Playlist.Rows[7]["tenbaihat"].ToString();
                    labelPlaylist32.Text = Playlist.Rows[7]["thoiluong"].ToString();
                    break;
                case 8:
                    panelPlaylist1.Visible = true;
                    panelPlaylist2.Visible = true;
                    panelPlaylist3.Visible = true;
                    panelPlaylist4.Visible = true;
                    panelPlaylist5.Visible = true;
                    panelPlaylist6.Visible = true;
                    panelPlaylist7.Visible = true;
                    panelPlaylist8.Visible = true;
                    panelPlaylist9.Visible = true;
                    panelPlaylist10.Visible = false;

                    picPlaylist1.BackgroundImage = (Image)Playlist.Rows[0]["hinhanh"];
                    labelPlaylist1.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist3.Text = Playlist.Rows[0]["tencasi"].ToString();
                    labelPlaylist2.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist4.Text = Playlist.Rows[0]["thoiluong"].ToString();

                    picPlaylist2.BackgroundImage = (Image)Playlist.Rows[1]["hinhanh"];
                    labelPlaylist5.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist7.Text = Playlist.Rows[1]["tencasi"].ToString();
                    labelPlaylist6.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist8.Text = Playlist.Rows[1]["thoiluong"].ToString();

                    picPlaylist3.BackgroundImage = (Image)Playlist.Rows[2]["hinhanh"];
                    labelPlaylist9.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist11.Text = Playlist.Rows[2]["tencasi"].ToString();
                    labelPlaylist10.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist12.Text = Playlist.Rows[2]["thoiluong"].ToString();

                    picPlaylist4.BackgroundImage = (Image)Playlist.Rows[3]["hinhanh"];
                    labelPlaylist13.Text = Playlist.Rows[3]["tenbaihat"].ToString();
                    labelPlaylist15.Text = Playlist.Rows[3]["tencasi"].ToString();
                    labelPlaylist14.Text = Playlist.Rows[3]["tenbaihat"].ToString();
                    labelPlaylist16.Text = Playlist.Rows[3]["thoiluong"].ToString();

                    picPlaylist5.BackgroundImage = (Image)Playlist.Rows[4]["hinhanh"];
                    labelPlaylist17.Text = Playlist.Rows[4]["tenbaihat"].ToString();
                    labelPlaylist19.Text = Playlist.Rows[4]["tencasi"].ToString();
                    labelPlaylist18.Text = Playlist.Rows[4]["tenbaihat"].ToString();
                    labelPlaylist20.Text = Playlist.Rows[4]["thoiluong"].ToString();

                    picPlaylist6.BackgroundImage = (Image)Playlist.Rows[5]["hinhanh"];
                    labelPlaylist21.Text = Playlist.Rows[5]["tenbaihat"].ToString();
                    labelPlaylist23.Text = Playlist.Rows[5]["tencasi"].ToString();
                    labelPlaylist22.Text = Playlist.Rows[5]["tenbaihat"].ToString();
                    labelPlaylist24.Text = Playlist.Rows[5]["thoiluong"].ToString();

                    picPlaylist7.BackgroundImage = (Image)Playlist.Rows[6]["hinhanh"];
                    labelPlaylist25.Text = Playlist.Rows[6]["tenbaihat"].ToString();
                    labelPlaylist27.Text = Playlist.Rows[6]["tencasi"].ToString();
                    labelPlaylist26.Text = Playlist.Rows[6]["tenbaihat"].ToString();
                    labelPlaylist28.Text = Playlist.Rows[6]["thoiluong"].ToString();

                    picPlaylist8.BackgroundImage = (Image)Playlist.Rows[7]["hinhanh"];
                    labelPlaylist29.Text = Playlist.Rows[7]["tenbaihat"].ToString();
                    labelPlaylist31.Text = Playlist.Rows[7]["tencasi"].ToString();
                    labelPlaylist30.Text = Playlist.Rows[7]["tenbaihat"].ToString();
                    labelPlaylist32.Text = Playlist.Rows[7]["thoiluong"].ToString();

                    picPlaylist9.BackgroundImage = (Image)Playlist.Rows[8]["hinhanh"];
                    labelPlaylist33.Text = Playlist.Rows[8]["tenbaihat"].ToString();
                    labelPlaylist35.Text = Playlist.Rows[8]["tencasi"].ToString();
                    labelPlaylist34.Text = Playlist.Rows[8]["tenbaihat"].ToString();
                    labelPlaylist36.Text = Playlist.Rows[8]["thoiluong"].ToString();
                    break;
                case 9:
                    panelPlaylist1.Visible = true;
                    panelPlaylist2.Visible = true;
                    panelPlaylist3.Visible = true;
                    panelPlaylist4.Visible = true;
                    panelPlaylist5.Visible = true;
                    panelPlaylist6.Visible = true;
                    panelPlaylist7.Visible = true;
                    panelPlaylist8.Visible = true;
                    panelPlaylist9.Visible = true;
                    panelPlaylist10.Visible = true;

                    picPlaylist1.BackgroundImage = (Image)Playlist.Rows[0]["hinhanh"];
                    labelPlaylist1.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist3.Text = Playlist.Rows[0]["tencasi"].ToString();
                    labelPlaylist2.Text = Playlist.Rows[0]["tenbaihat"].ToString();
                    labelPlaylist4.Text = Playlist.Rows[0]["thoiluong"].ToString();

                    picPlaylist2.BackgroundImage = (Image)Playlist.Rows[1]["hinhanh"];
                    labelPlaylist5.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist7.Text = Playlist.Rows[1]["tencasi"].ToString();
                    labelPlaylist6.Text = Playlist.Rows[1]["tenbaihat"].ToString();
                    labelPlaylist8.Text = Playlist.Rows[1]["thoiluong"].ToString();

                    picPlaylist3.BackgroundImage = (Image)Playlist.Rows[2]["hinhanh"];
                    labelPlaylist9.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist11.Text = Playlist.Rows[2]["tencasi"].ToString();
                    labelPlaylist10.Text = Playlist.Rows[2]["tenbaihat"].ToString();
                    labelPlaylist12.Text = Playlist.Rows[2]["thoiluong"].ToString();

                    picPlaylist4.BackgroundImage = (Image)Playlist.Rows[3]["hinhanh"];
                    labelPlaylist13.Text = Playlist.Rows[3]["tenbaihat"].ToString();
                    labelPlaylist15.Text = Playlist.Rows[3]["tencasi"].ToString();
                    labelPlaylist14.Text = Playlist.Rows[3]["tenbaihat"].ToString();
                    labelPlaylist16.Text = Playlist.Rows[3]["thoiluong"].ToString();

                    picPlaylist5.BackgroundImage = (Image)Playlist.Rows[4]["hinhanh"];
                    labelPlaylist17.Text = Playlist.Rows[4]["tenbaihat"].ToString();
                    labelPlaylist19.Text = Playlist.Rows[4]["tencasi"].ToString();
                    labelPlaylist18.Text = Playlist.Rows[4]["tenbaihat"].ToString();
                    labelPlaylist20.Text = Playlist.Rows[4]["thoiluong"].ToString();

                    picPlaylist6.BackgroundImage = (Image)Playlist.Rows[5]["hinhanh"];
                    labelPlaylist21.Text = Playlist.Rows[5]["tenbaihat"].ToString();
                    labelPlaylist23.Text = Playlist.Rows[5]["tencasi"].ToString();
                    labelPlaylist22.Text = Playlist.Rows[5]["tenbaihat"].ToString();
                    labelPlaylist24.Text = Playlist.Rows[5]["thoiluong"].ToString();

                    picPlaylist7.BackgroundImage = (Image)Playlist.Rows[6]["hinhanh"];
                    labelPlaylist25.Text = Playlist.Rows[6]["tenbaihat"].ToString();
                    labelPlaylist27.Text = Playlist.Rows[6]["tencasi"].ToString();
                    labelPlaylist26.Text = Playlist.Rows[6]["tenbaihat"].ToString();
                    labelPlaylist28.Text = Playlist.Rows[6]["thoiluong"].ToString();

                    picPlaylist8.BackgroundImage = (Image)Playlist.Rows[7]["hinhanh"];
                    labelPlaylist29.Text = Playlist.Rows[7]["tenbaihat"].ToString();
                    labelPlaylist31.Text = Playlist.Rows[7]["tencasi"].ToString();
                    labelPlaylist30.Text = Playlist.Rows[7]["tenbaihat"].ToString();
                    labelPlaylist32.Text = Playlist.Rows[7]["thoiluong"].ToString();

                    picPlaylist9.BackgroundImage = (Image)Playlist.Rows[8]["hinhanh"];
                    labelPlaylist33.Text = Playlist.Rows[8]["tenbaihat"].ToString();
                    labelPlaylist35.Text = Playlist.Rows[8]["tencasi"].ToString();
                    labelPlaylist34.Text = Playlist.Rows[8]["tenbaihat"].ToString();
                    labelPlaylist36.Text = Playlist.Rows[8]["thoiluong"].ToString();

                    picPlaylist10.BackgroundImage = (Image)Playlist.Rows[9]["hinhanh"];
                    labelPlaylist37.Text = Playlist.Rows[9]["tenbaihat"].ToString();
                    labelPlaylist39.Text = Playlist.Rows[9]["tencasi"].ToString();
                    labelPlaylist38.Text = Playlist.Rows[9]["tenbaihat"].ToString();
                    labelPlaylist40.Text = Playlist.Rows[9]["thoiluong"].ToString();
                    break;
            }
        }

        private void labelPlaylistShow_MouseMove(object sender, MouseEventArgs e)
        {
            var font = labelPlaylistShow.Font;
            labelPlaylistShow.Font = new Font("Yu Gothic Medium", 10, FontStyle.Underline | FontStyle.Bold);
            labelPlaylistShow.ForeColor = Color.WhiteSmoke;
        }

        private void labelPlaylistShow_MouseLeave(object sender, EventArgs e)
        {
            var font = labelPlaylistShow.Font;
            labelPlaylistShow.Font = new Font("Yu Gothic Medium", 10, FontStyle.Regular | FontStyle.Bold);
            labelPlaylistShow.ForeColor = Color.Silver;
        }

        private void labelPlaylist1_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            panelLiked.Visible = false;
            picNowPlay.BackgroundImage = picPlaylist1.BackgroundImage;
            labelNowPlay.Text = labelPlaylist1.Text;
            labelNowArtist.Text = labelPlaylist3.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Playlist.Rows[0]["baihat"].ToString();
            player.Play();
        }

        private void labelPlaylist5_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            panelLiked.Visible = false;
            picNowPlay.BackgroundImage = picPlaylist2.BackgroundImage;
            labelNowPlay.Text = labelPlaylist5.Text;
            labelNowArtist.Text = labelPlaylist7.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Playlist.Rows[1]["baihat"].ToString();
            player.Play();
        }

        private void labelPlaylist9_Click(object sender, EventArgs e)
        {
            panelLiked.Visible = false;
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picPlaylist3.BackgroundImage;
            labelNowPlay.Text = labelPlaylist9.Text;
            labelNowArtist.Text = labelPlaylist11.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Playlist.Rows[2]["baihat"].ToString();
            player.Play();
        }

        private void labelPlaylist13_Click(object sender, EventArgs e)
        {
            panelLiked.Visible = false;
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picPlaylist4.BackgroundImage;
            labelNowPlay.Text = labelPlaylist13.Text;
            labelNowArtist.Text = labelPlaylist15.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Playlist.Rows[3]["baihat"].ToString();
            player.Play();
        }

        private void labelPlaylist17_Click(object sender, EventArgs e)
        {
            panelLiked.Visible = false;
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picPlaylist5.BackgroundImage;
            labelNowPlay.Text = labelPlaylist17.Text;
            labelNowArtist.Text = labelPlaylist19.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Playlist.Rows[4]["baihat"].ToString();
            player.Play();
        }

        private void labelPlaylist21_Click(object sender, EventArgs e)
        {
            panelLiked.Visible = false;
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picPlaylist6.BackgroundImage;
            labelNowPlay.Text = labelPlaylist21.Text;
            labelNowArtist.Text = labelPlaylist23.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Playlist.Rows[5]["baihat"].ToString();
            player.Play();
        }

        private void labelPlaylist25_Click(object sender, EventArgs e)
        {
            panelLiked.Visible = false;
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picPlaylist7.BackgroundImage;
            labelNowPlay.Text = labelPlaylist25.Text;
            labelNowArtist.Text = labelPlaylist27.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Playlist.Rows[6]["baihat"].ToString();
            player.Play();
        }

        private void labelPlaylist29_Click(object sender, EventArgs e)
        {
            panelLiked.Visible = false;
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picPlaylist8.BackgroundImage;
            labelNowPlay.Text = labelPlaylist29.Text;
            labelNowArtist.Text = labelPlaylist31.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Playlist.Rows[7]["baihat"].ToString();
            player.Play();
        }

        private void labelPlaylist33_Click(object sender, EventArgs e)
        {
            panelLiked.Visible = false;
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picPlaylist9.BackgroundImage;
            labelNowPlay.Text = labelPlaylist33.Text;
            labelNowArtist.Text = labelPlaylist35.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Playlist.Rows[8]["baihat"].ToString();
            player.Play();
        }

        private void labelPlaylist37_Click(object sender, EventArgs e)
        {
            panelLiked.Visible = false;
            panelInfo.Visible = false;
            picNowPlay.BackgroundImage = picPlaylist10.BackgroundImage;
            labelNowPlay.Text = labelPlaylist37.Text;
            labelNowArtist.Text = labelPlaylist39.Text;
            buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

            player.Stop();
            player.SoundLocation = Playlist.Rows[9]["baihat"].ToString();
            player.Play();
        }

        private void labelNowPlay_TextChanged(object sender, EventArgs e)
        {
            labelHistoryName.Text = (labelNowPlay.Text + "\r\n");
            labelHistoryTime.Text = (DateTime.Now.ToString() + "\r\n");
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            switch (labelDecorMusic.Text)
            {
                case "#AiChoAi":
                    {
                      
                        string src = @"D:\CS511 C# Language\music\musicdemo\vn\VN FloD -  #AiChoAi.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\VN FloD -  #AiChoAi.wav";

                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }
                        
                        break;
                    }
                case "Không sao đâu":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\vn\VN cam - không sao đâu.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\VN cam - không sao đâu.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Sài Gòn buồn quá em ơi":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\vn\VN Dế Choắt - Sài Gòn buồn quá em ơi.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\VN Dế Choắt - Sài Gòn buồn quá em ơi.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Trốn tìm":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\vn\VN Đen - Trốn Tìm.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\VN Đen - Trốn Tìm.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Loving You Sunny":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\vn\VN Kimmese - Loving You Sunny.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\VN Kimmese - Loving You Sunny.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Chuyện chàng trông xe":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\vn\VN MCK - Chuyện chàng trông xe.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\VN MCK - Chuyện chàng trông xe.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Anh không thề gì đâu anh làm":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\vn\VN PHÚC DU - ANH KHÔNG THỀ GÌ ĐÂU ANH LÀM.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\VN PHÚC DU - ANH KHÔNG THỀ GÌ ĐÂU ANH LÀM.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Trên Lầu Cao":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\vn\VN Rhymastic - Trên Lầu Cao.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\VN Rhymastic - Trên Lầu Cao.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Nhập gia tùy tục":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\vn\VN Sol7 - Nhập Gia Tuỳ Tục.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\VN Sol7 - Nhập Gia Tuỳ Tục.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Blue Tequila":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\vn\VN Táo - Blue Tequila.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\VN Táo - Blue Tequila.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "The Lazy Song":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\eng\ENG Bruno Mars - The Lazy Song.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\ENG Bruno Mars - The Lazy Song.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Heat Waves":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\eng\ENG Glass Animals - Heat Waves.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\ENG Glass Animals - Heat Waves.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Head In The Cloud":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\eng\ENG Hayd - Head In The Clouds.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\ENG Hayd - Head In The Clouds.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "comethru":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\eng\ENG Jeremy Zucker - comethru.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\ENG Jeremy Zucker - comethru.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Paris in the Rain":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\eng\ENG Lauv - Paris in the Rain.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\ENG Lauv - Paris in the Rain.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Rude":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\eng\ENG MAGIC - Rude.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\ENG MAGIC - Rude.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "When I Grow Up":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\eng\ENG NF - When I Grow Up.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\ENG NF - When I Grow Up.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Counting Stars":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\eng\ENG OneRepublic - Counting Stars.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\ENG OneRepublic - Counting Stars.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "death bed":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\eng\ENG Powfu - death bed.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\ENG Powfu - death bed.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Stressed out":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\eng\ENG twenty one pilots - Stressed Out.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\ENG twenty one pilots - Stressed Out.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Heads Will Roll":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\edm\EDM Amfree & Ampris - Heads Will Roll.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\EDM Amfree & Ampris - Heads Will Roll.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Waiting For Love":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\edm\EDM Avicii - Waiting For Love.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\EDM Avicii - Waiting For Love.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "If Only I Could":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\edm\EDM Brooks - If Only I Could.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\EDM Brooks - If Only I Could.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Journey":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\edm\EDM Don Diablo - Journey.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\EDM Don Diablo - Journey.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Where Are You Now":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\edm\EDM Lost Frequencies - Where Are You Now.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\EDM Lost Frequencies - Where Are You Now.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Silence":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\edm\EDM Marshmello - Silence.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\EDM Marshmello - Silence.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Leyla":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\edm\EDM Mesto - Leyla.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\EDM Mesto - Leyla.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "When The Sun's Gone":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\edm\EDM Mike Williams - When The Sun Is Gone.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\EDM Mike Williams - When The Sun Is Gone.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Bullet Waiting For Me":
                    
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\edm\EDM Nikki Simmons - Bullet Waiting For Me.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\EDM Nikki Simmons - Bullet Waiting For Me.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
                case "Roses":
                    {
                        string src = @"D:\CS511 C# Language\music\musicdemo\edm\EDM The Chainsmokers - Roses.wav";
                        string dtn = @"D:\CS511 C# Language\music\musicDownloaded\EDM The Chainsmokers - Roses.wav";
                        if (File.Exists(dtn)) MessageBox.Show("Music already exists in file musicDownloaded");

                        else

                        { File.Copy(src, dtn); MessageBox.Show("File Downloaded!"); }

                        break;
                    }
            }
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File downloaded");
        }

        private void textBoxCmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            switch (labelNowPlay.Text)
            {
                case "#AiChoAi":

                    VN.Rows[0]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[0]["binhluan"].ToString();
                    break;
                case "Không sao đâu":
                    VN.Rows[1]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[1]["binhluan"].ToString();
                    break;
                case "Sài Gòn buồn quá em ơi":
                    VN.Rows[2]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[2]["binhluan"].ToString();
                    break;
                case "Trốn tìm":
                    VN.Rows[3]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[3]["binhluan"].ToString();
                    break;
                case "Loving You Sunny":
                    VN.Rows[4]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[4]["binhluan"].ToString();
                    break;
                case "Chuyện chàng trông xe":
                    VN.Rows[5]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[5]["binhluan"].ToString();
                    break;
                case "Anh không thề gì đâu anh làm":
                    VN.Rows[6]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[6]["binhluan"].ToString();
                    break;
                case "Trên Lầu Cao":
                    VN.Rows[7]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[7]["binhluan"].ToString();
                    break;
                case "Nhập gia tùy tục":
                    VN.Rows[8]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[8]["binhluan"].ToString();
                    break;
                case "Blue Tequila":
                    VN.Rows[9]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = VN.Rows[9]["binhluan"].ToString();
                    break;
                case "The Lazy Song":
                    EN.Rows[0]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[0]["binhluan"].ToString();
                    break;
                case "Heat Waves":
                    EN.Rows[1]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[1]["binhluan"].ToString();
                    break;
                case "Head In The Cloud":
                    EN.Rows[2]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[2]["binhluan"].ToString();
                    break;
                case "comethru":
                    EN.Rows[3]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[3]["binhluan"].ToString();
                    break;
                case "Paris in the Rain":
                    EN.Rows[4]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[4]["binhluan"].ToString();
                    break;
                case "Rude":
                    EN.Rows[5]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[5]["binhluan"].ToString();
                    break;
                case "When I Grow Up":
                    EN.Rows[6]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[6]["binhluan"].ToString();
                    break;
                case "Counting Stars":
                    EN.Rows[7]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[7]["binhluan"].ToString();
                    break;
                case "death bed":
                    EN.Rows[8]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[8]["binhluan"].ToString();
                    break;
                case "Stressed out":
                    EN.Rows[9]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EN.Rows[9]["binhluan"].ToString();
                    break;
                case "Heads Will Roll":
                    EDM.Rows[0]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[0]["binhluan"].ToString();
                    break;
                case "Waiting For Love":
                    EDM.Rows[1]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[1]["binhluan"].ToString();
                    break;
                case "If Only I Could":
                    EDM.Rows[2]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[2]["binhluan"].ToString();
                    break;
                case "Journey":
                    EDM.Rows[3]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[3]["binhluan"].ToString();
                    break;
                case "Where Are You Now":
                    EDM.Rows[4]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[4]["binhluan"].ToString();
                    break;
                case "Silence":
                    EDM.Rows[5]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[5]["binhluan"].ToString();
                    break;
                case "Leyla":
                    EDM.Rows[6]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[6]["binhluan"].ToString();
                    break;
                case "When The Sun's Gone":
                    EDM.Rows[7]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[7]["binhluan"].ToString();
                    break;
                case "Bullet Waiting For Me":
                    EDM.Rows[8]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[8]["binhluan"].ToString();
                    break;
                case "Roses":
                    EDM.Rows[9]["binhluan"] += ("Anonymous\r\n" + textBoxCmt.Text + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    labelShowComment.Text = EDM.Rows[9]["binhluan"].ToString();
                    break;
            }
        }
        //picNowPlay.BackgroundImage = picLiked6.BackgroundImage;
        //    labelNowPlay.Text = labelLiked21.Text;
        //    labelNowArtist.Text = labelLiked23.Text;
        //    buttonPause.BackgroundImage = Properties.Resources._211871_pause_icon;

        //    player.Stop();
        //    player.SoundLocation = Like.Rows[5]["baihat"].ToString();
        //player.Play();
        private void labelHistoryName_Click(object sender, EventArgs e)
        {

        }
    }
}
