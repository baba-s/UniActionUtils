using System;

namespace Kogane
{
	/// <summary>
	/// Action 型の汎用的な関数を管理するクラス
	/// </summary>
	public static class ActionUtils
	{
		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// 指定された Action デリゲートを実行します
		/// 実行した Action デリゲートは null になります
		/// </summary>
		public static void CallOnce( ref Action self )
		{
			var action = self;
			self = null;
			action();
		}

		/// <summary>
		/// 指定された Action デリゲートを実行します
		/// 実行した Action デリゲートは null になります
		/// </summary>
		public static void CallOnce<T>( ref Action<T> self, T arg1 )
		{
			var action = self;
			self = null;
			action( arg1 );
		}

		/// <summary>
		/// 指定された Action デリゲートを実行します
		/// 実行した Action デリゲートは null になります
		/// </summary>
		public static void CallOnce<T1, T2>
		(
			ref Action<T1, T2> self,
			T1                 arg1,
			T2                 arg2
		)
		{
			var action = self;
			self = null;
			action( arg1, arg2 );
		}

		/// <summary>
		/// 指定された Action デリゲートを実行します
		/// 実行した Action デリゲートは null になります
		/// </summary>
		public static void CallOnce<T1, T2, T3>
		(
			ref Action<T1, T2, T3> self,
			T1                     arg1,
			T2                     arg2,
			T3                     arg3
		)
		{
			var action = self;
			self = null;
			action( arg1, arg2, arg3 );
		}

		/// <summary>
		/// 指定された Action デリゲートを実行します
		/// 実行した Action デリゲートは null になります
		/// </summary>
		public static void CallOnce<T1, T2, T3, T4>
		(
			ref Action<T1, T2, T3, T4> self,
			T1                         arg1,
			T2                         arg2,
			T3                         arg3,
			T4                         arg4
		)
		{
			var action = self;
			self = null;
			action( arg1, arg2, arg3, arg4 );
		}

		/// <summary>
		/// 指定された Action デリゲートを実行します
		/// 実行した Action デリゲートは null になります
		/// </summary>
		public static void CallOnceIfNotNull( ref Action self )
		{
			if ( self == null ) return;
			CallOnce( ref self );
		}

		/// <summary>
		/// 指定された Action デリゲートを実行します
		/// 実行した Action デリゲートは null になります
		/// </summary>
		public static void CallOnceIfNotNull<T>( ref Action<T> self, T arg1 )
		{
			if ( self == null ) return;
			CallOnce( ref self, arg1 );
		}

		/// <summary>
		/// 指定された Action デリゲートを実行します
		/// 実行した Action デリゲートは null になります
		/// </summary>
		public static void CallOnceIfNotNull<T1, T2>
		(
			ref Action<T1, T2> self,
			T1                 arg1,
			T2                 arg2
		)
		{
			if ( self == null ) return;
			CallOnce( ref self, arg1, arg2 );
		}

		/// <summary>
		/// 指定された Action デリゲートを実行します
		/// 実行した Action デリゲートは null になります
		/// </summary>
		public static void CallOnceIfNotNull<T1, T2, T3>
		(
			ref Action<T1, T2, T3> self,
			T1                     arg1,
			T2                     arg2,
			T3                     arg3
		)
		{
			if ( self == null ) return;
			CallOnce( ref self, arg1, arg2, arg3 );
		}

		/// <summary>
		/// 指定された Action デリゲートを実行します
		/// 実行した Action デリゲートは null になります
		/// </summary>
		public static void CallOnceIfNotNull<T1, T2, T3, T4>
		(
			ref Action<T1, T2, T3, T4> self,
			T1                         arg1,
			T2                         arg2,
			T3                         arg3,
			T4                         arg4
		)
		{
			if ( self == null ) return;
			CallOnce( ref self, arg1, arg2, arg3, arg4 );
		}
	}
}