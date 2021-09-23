using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZendeskApi_v2.Models.Articles;

namespace SourceStacks.Pages
{
	public class Repositories
	{
		static IList<Content> Contents;

		static Repositories()
		{
			Contents = new List<Content> {
				new Content
				{
					Id=1,
					Title="Java��������󣺼̳� / ��̬",
					Body="�̳�ʹ�ùؼ���extends��ʾ�̳У�super��ʾ���� public class OnlineStudent extends Student {public OnlineStudent(int age) {super(age);}}final��������/������ͬsealedinstanceof��ͬis��û��asPerson fg = new Teacher();System.out.println(fg instanceof Person);System.out.println(fg instanceof ",
					PublishTime=DateTime.Now,
					Answer=100,
					Summary=20,
					Reward=30,
					Author=new User{
						Id=1,
						Name="�ɸ�",
					},
					keywords=new List<Keyword>
					{
						new Keyword
						{
							Name="Java"
						},
						new Keyword
						{
							Name="�������"
						},
						new Keyword
						{
							Name="�̳�"
						}
					}

				},
				new Content
				{
					Id=2,
					Title="J&C��������󣺹��캯�� / ��ֹ�̳� / ������ / �ӿ�",
					Body="�̳�ʹ�ùؼ���extends��ʾ�̳У�super��ʾ���� public class OnlineStudent extends Student {public OnlineStudent(int age) {super(age);}}final��������/������ͬsealedinstanceof��ͬis��û��asPerson fg = new Teacher();System.out.println(fg instanceof Person);System.out.println(fg instanceof ",
					PublishTime=DateTime.Now,
					Answer=100,
					Summary=20,
					Reward=30,
					Author=new User{
						Id=1,
						Name="С��",
					},
					keywords=new List<Keyword>
					{
						new Keyword
						{
							Name="C#"
						},
						new Keyword
						{
							Name="�������"
						},
						new Keyword
						{
							Name="��̬"
						}
					}

				},new Content
				{
					Id=3,
					Title=" python���治�ܹ��õ���ַ",
					Body="��ʮ��֮����ϣ���ĳ������������ࣺ��Ӧ�Խ������������ʽ����ķϵ�ͬѧΪҰ������Գ���� ����Դջ��ͬѧ���Խ���������������֮�£��ӵͶ���ũ��߶��˲�������������������������������ӯ�����¡���ܽ��ܵĳ��������ŵ�������ĳ��ĳ��һ���������ʮ��������Ȩ�������ҽ��һ�����ôʮ����ѧ������ÿ��ѧ����ѧ�����ɣ����پ���ѧ�ѻ�ֵ����Թ�ҷɸ磬Ҳ��OK�ˡ��ؼ����ˣ�ͬ־�������Ķ���һ��Ĺ�˾����һ�����湲ͬ�塣������������ϣ�����ұ��뱣֤��Դջ��һ�����빲ͬ�塣�ڽ������ᣬ���ܲ����ҵ��������ˣ��ҵ��ܶ�ܶ��������ˣ�",
					PublishTime=DateTime.Now,
					Answer=100,
					Summary=20,
					Reward=30,
					Author=new User{
						Id=1,
						Name="С��",
					},
					keywords=new List<Keyword>
					{
						new Keyword
						{
							Name="Sql"
						},
						new Keyword
						{
							Name="������"
						},
						new Keyword
						{
							Name="Update"
						}
					}

				},new Content
				{
					Id=4,
					Title=" ������רӦ�����Ҹ�JAVA�����Ĺ�������û���Ƽ��� / ",
					Body="����3���º��ҵ����ѧ3��JAVA����J2EE��һ���׿�����ϵ�ǳ���Ϥ��OA�����Ŀ���ıȽ϶ࡣ�ٻ�ڰ˽����ű�JAVA C�������ȫ��һ�Ƚ���֮��ȥ�Ϻ�ʵϰ�����£���ΪһЩԭ������������չ������Ͷ����������Ҫôû�����ţ�Ҫô��һ�����Խ���û����Ϣ��Ҫôѧ��������--��������������JAVAУ�м���û�У�1���¹�ȥ�ˣ�����û�й������Ҷ������ʣ�ֻ���г�Զ��չ��������Ҷ�Ը��ѧ�����ǲ���ȥ���ֻ����ӵĹ�˾��Ҫ�м��飬�д��£�����Ѫ�Ĺ�˾����û���Ƽ��ģ�������λ��������ҿ�������һ���ң����ٸ������Ի��ᡭ��",
					PublishTime=DateTime.Now,
					Answer=100,
					Summary=20,
					Reward=30,
					Author=new User{
						Id=1,
						Name="�ɸ�",
					},
					keywords=new List<Keyword>
					{
						new Keyword
						{
							Name="Java"
						},
						new Keyword
						{
							Name="�������"
						},
						new Keyword
						{
							Name="�̳�"
						}
					}

				},new Content
				{
					Id=5,
					Title="�ǹ�ƻ���alpha�棩���������ǣ�һ��֤����û��һֽ��ƾ����Ȼ���Ի�þ��ʣ�",
					Body="�̳�ʹ�ùؼ���extends��ʾ�̳У�super��ʾ���� public class OnlineStudent extends Student {public OnlineStudent(int age) {super(age);}}final��������/������ͬsealedinstanceof��ͬis��û��asPerson fg = new Teacher();System.out.println(fg instanceof Person);System.out.println(fg instanceof ",
					PublishTime=DateTime.Now,
					Answer=100,
					Summary=20,
					Reward=30,
					Author=new User{
						Id=1,
						Name="�ɸ�",
					},
					keywords=new List<Keyword>
					{
						new Keyword
						{
							Name="Java"
						},
						new Keyword
						{
							Name="�������"
						},
						new Keyword
						{
							Name="�̳�"
						}
					}

				},new Content
				{
					Id=6,
					Title="����ƾ���ѵ���ᣬ�ѵ���û�ие�һ�־�����",
					Body="�̳�ʹ�ùؼ���extends��ʾ�̳У�super��ʾ���� public class OnlineStudent extends Student {public OnlineStudent(int age) {super(age);}}final��������/������ͬsealedinstanceof��ͬis��û��asPerson fg = new Teacher();System.out.println(fg instanceof Person);System.out.println(fg instanceof ",
					PublishTime=DateTime.Now,
					Answer=100,
					Summary=20,
					Reward=30,
					Author=new User{
						Id=1,
						Name="�ɸ�",
					},
					keywords=new List<Keyword>
					{
						new Keyword
						{
							Name="Java"
						},
						new Keyword
						{
							Name="�������"
						},
						new Keyword
						{
							Name="�̳�"
						}
					}

				},new Content
				{
					Id=7,
					Title="mock.js��ģ���̨��Ӧ",
					Body="�̳�ʹ�ùؼ���extends��ʾ�̳У�super��ʾ���� public class OnlineStudent extends Student {public OnlineStudent(int age) {super(age);}}final��������/������ͬsealedinstanceof��ͬis��û��asPerson fg = new Teacher();System.out.println(fg instanceof Person);System.out.println(fg instanceof ",
					PublishTime=DateTime.Now,
					Answer=100,
					Summary=20,
					Reward=30,
					Author=new User{
						Id=1,
						Name="�ɸ�",
					},
					keywords=new List<Keyword>
					{
						new Keyword
						{
							Name="Java"
						},
						new Keyword
						{
							Name="�������"
						},
						new Keyword
						{
							Name="�̳�"
						}
					}

				},new Content
				{
					Id=8,
					Title="GitԶ�̣�push / pull / clone / fetch / conflict",
					Body="�̳�ʹ�ùؼ���extends��ʾ�̳У�super��ʾ���� public class OnlineStudent extends Student {public OnlineStudent(int age) {super(age);}}final��������/������ͬsealedinstanceof��ͬis��û��asPerson fg = new Teacher();System.out.println(fg instanceof Person);System.out.println(fg instanceof ",
					PublishTime=DateTime.Now,
					Answer=100,
					Summary=20,
					Reward=30,
					Author=new User{
						Id=1,
						Name="�ɸ�",
					},
					keywords=new List<Keyword>
					{
						new Keyword
						{
							Name="Java"
						},
						new Keyword
						{
							Name="�������"
						},
						new Keyword
						{
							Name="�̳�"
						}
					}

				}


			};
		}
		public IList<Article.Content> Get(int pageIndex, int pageSize)
		{
			return Contents.Skip((pageIndex - 1) * pageSize)
				.Take(pageSize).ToList();
			//return Articles;
		}
		public int GetCount()
		{
			return Contents.Count();
		}

	}
}