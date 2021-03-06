// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Async
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Error returned by methods for polling the status of asynchronous job.</para>
    /// </summary>
    public class PollError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PollError> Encoder = new PollErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PollError> Decoder = new PollErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PollError" /> class.</para>
        /// </summary>
        public PollError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidAsyncJobId</para>
        /// </summary>
        public bool IsInvalidAsyncJobId
        {
            get
            {
                return this is InvalidAsyncJobId;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidAsyncJobId, or <c>null</c>.</para>
        /// </summary>
        public InvalidAsyncJobId AsInvalidAsyncJobId
        {
            get
            {
                return this as InvalidAsyncJobId;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InternalError</para>
        /// </summary>
        public bool IsInternalError
        {
            get
            {
                return this is InternalError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InternalError, or <c>null</c>.</para>
        /// </summary>
        public InternalError AsInternalError
        {
            get
            {
                return this as InternalError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PollError" />.</para>
        /// </summary>
        private class PollErrorEncoder : enc.StructEncoder<PollError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PollError value, enc.IJsonWriter writer)
            {
                if (value is InvalidAsyncJobId)
                {
                    WriteProperty(".tag", "invalid_async_job_id", writer, enc.StringEncoder.Instance);
                    InvalidAsyncJobId.Encoder.EncodeFields((InvalidAsyncJobId)value, writer);
                    return;
                }
                if (value is InternalError)
                {
                    WriteProperty(".tag", "internal_error", writer, enc.StringEncoder.Instance);
                    InternalError.Encoder.EncodeFields((InternalError)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PollError" />.</para>
        /// </summary>
        private class PollErrorDecoder : enc.UnionDecoder<PollError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PollError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PollError Create()
            {
                return new PollError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override PollError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "invalid_async_job_id":
                        return InvalidAsyncJobId.Decoder.DecodeFields(reader);
                    case "internal_error":
                        return InternalError.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The job ID is invalid.</para>
        /// </summary>
        public sealed class InvalidAsyncJobId : PollError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidAsyncJobId> Encoder = new InvalidAsyncJobIdEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidAsyncJobId> Decoder = new InvalidAsyncJobIdDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidAsyncJobId" />
            /// class.</para>
            /// </summary>
            private InvalidAsyncJobId()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InvalidAsyncJobId</para>
            /// </summary>
            public static readonly InvalidAsyncJobId Instance = new InvalidAsyncJobId();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidAsyncJobId" />.</para>
            /// </summary>
            private class InvalidAsyncJobIdEncoder : enc.StructEncoder<InvalidAsyncJobId>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidAsyncJobId value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidAsyncJobId" />.</para>
            /// </summary>
            private class InvalidAsyncJobIdDecoder : enc.StructDecoder<InvalidAsyncJobId>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidAsyncJobId"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidAsyncJobId Create()
                {
                    return InvalidAsyncJobId.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Something went wrong with the job on Dropbox's end. You'll need to verify
        /// that the action you were taking succeeded, and if not, try again. This should
        /// happen very rarely.</para>
        /// </summary>
        public sealed class InternalError : PollError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InternalError> Encoder = new InternalErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InternalError> Decoder = new InternalErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InternalError" />
            /// class.</para>
            /// </summary>
            private InternalError()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InternalError</para>
            /// </summary>
            public static readonly InternalError Instance = new InternalError();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InternalError" />.</para>
            /// </summary>
            private class InternalErrorEncoder : enc.StructEncoder<InternalError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InternalError value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InternalError" />.</para>
            /// </summary>
            private class InternalErrorDecoder : enc.StructDecoder<InternalError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InternalError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InternalError Create()
                {
                    return InternalError.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : PollError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
