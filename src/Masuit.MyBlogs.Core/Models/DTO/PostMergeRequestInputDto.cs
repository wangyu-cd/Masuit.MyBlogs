using Masuit.MyBlogs.Core.Models.Validation;
using System.ComponentModel.DataAnnotations;

namespace Masuit.MyBlogs.Core.Models.DTO
{
    /// <summary>
    /// �����޸�����
    /// </summary>
    public class PostMergeRequestInputDto : PostMergeRequestInputDtoBase
    {
        /// <summary>
        /// ����id
        /// </summary>
        public int PostId { get; set; }

        /// <summary>
        /// �޸���
        /// </summary>
        [Required, MaxLength(36, ErrorMessage = "�޸��������֧��36���ַ���"), MinLength(2, ErrorMessage = "�޸�����������2���ַ���")]
        public string Modifier { get; set; }

        /// <summary>
        /// �޸�������
        /// </summary>
        [Required(ErrorMessage = "���䲻��Ϊ�գ�"), MinLength(6, ErrorMessage = "�����ʽ����ȷ��"), IsEmail]
        public string ModifierEmail { get; set; }
        /// <summary>
        /// ��֤��
        /// </summary>
        [Required(ErrorMessage = "��֤�벻��Ϊ�գ�")]
        public string Code { get; set; }
    }
}