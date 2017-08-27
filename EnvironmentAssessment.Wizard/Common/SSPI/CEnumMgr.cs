using System;
using System.Reflection;

namespace EnvironmentAssessment.Common.Sspi
{
    [AttributeUsage( AttributeTargets.Field )]
    public class CEnumStringAttribute : Attribute
    {
        public CEnumStringAttribute( string text )
        {
            this.Text = text;
        }

        public string Text { get; private set; }
    }

    public class CEnumMgr
    {
        public static string ToText( Enum value )
        {
            FieldInfo field = value.GetType().GetField( value.ToString() );

            CEnumStringAttribute[] attribs = (CEnumStringAttribute[])field.GetCustomAttributes( typeof( CEnumStringAttribute ), false );

            if( attribs == null || attribs.Length == 0 )
            {
                return null;
            }
            else
            {
                return attribs[0].Text;
            }
        }

        public static T FromText<T>( string text )
        {
            FieldInfo[] fields = typeof( T ).GetFields();

            CEnumStringAttribute[] attribs;

            foreach( FieldInfo field in fields )
            {
                attribs = (CEnumStringAttribute[])field.GetCustomAttributes( typeof( CEnumStringAttribute ), false );

                foreach( CEnumStringAttribute attrib in attribs )
                {
                    if( attrib.Text == text )
                    {
                        return (T)field.GetValue( null );
                    }
                }
            }

            throw new ArgumentException( "Could not find a matching enumeration value for the text '" + text + "'." );
        }
    }
}
