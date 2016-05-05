using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Spk.Core
{
	/// <summary>
	/// Represents a helper class to check function's input parameters and throw an argument exception.
	/// </summary>
	public static class Guardian
	{
		#region Null or Empty

		/// <summary>
		/// Determines whether parameter's value is null.
		/// </summary>
		/// <typeparam name="T">Parameter's type.</typeparam>
		/// <param name="parameterValue">Value of the parameter.</param>
		/// <param name="parameterName">Name of the parameter.</param>
		/// <exception cref="ArgumentNullException">
		/// In case of null value.
		/// </exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void IsNotNull<T>(T parameterValue, string parameterName)
			where T : class
		{
			if (parameterValue == null)
			{
				throw new ArgumentNullException(parameterName);
			}
		}

		/// <summary>
		/// Determines whether parameter's value is an empty structure.
		/// </summary>
		/// <typeparam name="T">Parameter's type</typeparam>
		/// <param name="parameterValue">Value of the parameter.</param>
		/// <param name="parameterName">Name of the parameter.</param>
		/// <exception cref="ArgumentNullException">
		/// In case of default value.
		/// </exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void IsNotEmpty<T>(T parameterValue, string parameterName)
			where T : struct
		{
			if (EqualityComparer<T>.Default.Equals(parameterValue, default(T)))
			{
				throw new ArgumentNullException(parameterName);
			}
		}

		/// <summary>
		/// Determines whether parameter's value is an empty array.
		/// </summary>
		/// <typeparam name="T">Parameter's type</typeparam>
		/// <param name="parameterValue">Value of the parameter.</param>
		/// <param name="parameterName">Name of the parameter.</param>
		/// <exception cref="ArgumentNullException">
		/// In case of null or default value.
		/// </exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void IsNotEmpty<T>(T[] parameterValue, string parameterName)
		{
			if (parameterValue == null || parameterValue.Length == 0)
			{
				throw new ArgumentNullException(parameterName);
			}
		}

		/// <summary>
		/// Determines whether parameter's value is an empty string.
		/// </summary>
		/// <param name="parameterValue">Value of the parameter.</param>
		/// <param name="parameterName">Name of the parameter.</param>
		/// <exception cref="ArgumentNullException">
		/// In case of null or empty string.
		/// </exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void IsNotEmpty(string parameterValue, string parameterName)
		{
			if (string.IsNullOrEmpty(parameterValue))
			{
				throw new ArgumentNullException(parameterName);
			}
		}

		#endregion

		#region Range

		/// <summary>
		/// Determines whether parameter's value is negative or zero.
		/// </summary>
		/// <param name="parameterValue">Value of the parameter.</param>
		/// <param name="parameterName">Name of the parameter.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// In case of negative number or zero.
		/// </exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void IsNotNegativeOrZero(long parameterValue, string parameterName)
		{
			if (parameterValue < 1)
			{
				throw new ArgumentOutOfRangeException(parameterName);
			}
		}

		#endregion
	}
}
