namespace Azure.Storage.Blobs
{
    public static partial class BlobContainerClientExtensions
    {
        public static System.Threading.Tasks.Task<Azure.Storage.DataMovement.DataTransfer> StartDownloadToDirectoryAsync(this Azure.Storage.Blobs.BlobContainerClient client, string localDirectoryPath, Azure.Storage.Blobs.Models.BlobContainerClientTransferOptions options) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Storage.DataMovement.DataTransfer> StartDownloadToDirectoryAsync(this Azure.Storage.Blobs.BlobContainerClient client, string localDirectoryPath, string blobDirectoryPrefix = null) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Storage.DataMovement.DataTransfer> StartUploadDirectoryAsync(this Azure.Storage.Blobs.BlobContainerClient client, string localDirectoryPath, Azure.Storage.Blobs.Models.BlobContainerClientTransferOptions options) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Storage.DataMovement.DataTransfer> StartUploadDirectoryAsync(this Azure.Storage.Blobs.BlobContainerClient client, string localDirectoryPath, string blobDirectoryPrefix = null) { throw null; }
    }
}
namespace Azure.Storage.Blobs.Models
{
    public partial class BlobContainerClientTransferOptions
    {
        public BlobContainerClientTransferOptions() { }
        public Azure.Storage.DataMovement.Blobs.BlobStorageResourceContainerOptions BlobContainerOptions { get { throw null; } set { } }
        public Azure.Storage.DataMovement.Models.TransferOptions TransferOptions { get { throw null; } set { } }
    }
}
namespace Azure.Storage.DataMovement.Blobs
{
    public partial class AppendBlobStorageResource : Azure.Storage.DataMovement.StorageResourceSingle
    {
        public AppendBlobStorageResource(Azure.Storage.Blobs.Specialized.AppendBlobClient blobClient, Azure.Storage.DataMovement.Blobs.AppendBlobStorageResourceOptions options = null) { }
        public override bool CanProduceUri { get { throw null; } }
        public override long? Length { get { throw null; } }
        public override long MaxChunkSize { get { throw null; } }
        public override string Path { get { throw null; } }
        public override string ResourceId { get { throw null; } }
        public override Azure.Storage.DataMovement.TransferType TransferType { get { throw null; } }
        public override System.Uri Uri { get { throw null; } }
        public override System.Threading.Tasks.Task CompleteTransferAsync(bool overwrite, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task CopyBlockFromUriAsync(Azure.Storage.DataMovement.StorageResourceSingle sourceResource, Azure.HttpRange range, bool overwrite, long completeLength = (long)0, Azure.Storage.DataMovement.Models.StorageResourceCopyFromUriOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task CopyFromUriAsync(Azure.Storage.DataMovement.StorageResourceSingle sourceResource, bool overwrite, long completeLength, Azure.Storage.DataMovement.Models.StorageResourceCopyFromUriOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task<bool> DeleteIfExistsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task<Azure.Storage.DataMovement.Models.StorageResourceProperties> GetPropertiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task<Azure.Storage.DataMovement.Models.ReadStreamStorageResourceResult> ReadStreamAsync(long position = (long)0, long? length = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task WriteFromStreamAsync(System.IO.Stream stream, long streamLength, bool overwrite, long position = (long)0, long completeLength = (long)0, Azure.Storage.DataMovement.Models.StorageResourceWriteToOffsetOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AppendBlobStorageResourceOptions : Azure.Storage.DataMovement.Blobs.BlobStorageResourceOptions
    {
        public AppendBlobStorageResourceOptions() { }
        public Azure.Storage.Blobs.Models.AppendBlobRequestConditions DestinationConditions { get { throw null; } set { } }
        public Azure.Storage.Blobs.Models.AppendBlobRequestConditions SourceConditions { get { throw null; } set { } }
    }
    public partial class BlobStorageResourceContainer : Azure.Storage.DataMovement.StorageResourceContainer
    {
        public BlobStorageResourceContainer(Azure.Storage.Blobs.BlobContainerClient blobContainerClient, Azure.Storage.DataMovement.Blobs.BlobStorageResourceContainerOptions options = null) { }
        public override bool CanProduceUri { get { throw null; } }
        public override string Path { get { throw null; } }
        public override System.Uri Uri { get { throw null; } }
        public override Azure.Storage.DataMovement.StorageResourceSingle GetChildStorageResource(string path) { throw null; }
        public override System.Collections.Generic.IAsyncEnumerable<Azure.Storage.DataMovement.StorageResource> GetStorageResourcesAsync([System.Runtime.CompilerServices.EnumeratorCancellationAttribute] System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BlobStorageResourceContainerOptions
    {
        public BlobStorageResourceContainerOptions() { }
        public Azure.Storage.Blobs.Models.BlobType BlobType { get { throw null; } set { } }
        public string DirectoryPrefix { get { throw null; } set { } }
        public Azure.Storage.DataMovement.Blobs.BlobStorageResourceOptions ResourceOptions { get { throw null; } set { } }
    }
    public partial class BlobStorageResourceOptions
    {
        public BlobStorageResourceOptions() { }
        public Azure.Storage.Blobs.Models.AccessTier? AccessTier { get { throw null; } set { } }
        public Azure.Storage.Blobs.Models.BlobImmutabilityPolicy DestinationImmutabilityPolicy { get { throw null; } set { } }
        public Azure.Storage.DownloadTransferValidationOptions DownloadTransferValidationOptions { get { throw null; } set { } }
        public Azure.Storage.Blobs.Models.BlobHttpHeaders HttpHeaders { get { throw null; } set { } }
        public bool? LegalHold { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Metadata { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } set { } }
        public Azure.Storage.UploadTransferValidationOptions UploadTransferValidationOptions { get { throw null; } set { } }
    }
    public partial class BlobStorageResourceProvider
    {
        internal BlobStorageResourceProvider() { }
        public System.Threading.Tasks.Task<Azure.Storage.DataMovement.StorageResource> MakeResourceAsync(Azure.AzureSasCredential credential, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public System.Threading.Tasks.Task<Azure.Storage.DataMovement.StorageResource> MakeResourceAsync(Azure.Core.TokenCredential credential, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public System.Threading.Tasks.Task<Azure.Storage.DataMovement.StorageResource> MakeResourceAsync(Azure.Storage.StorageSharedKeyCredential credential, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public System.Threading.Tasks.Task<Azure.Storage.DataMovement.StorageResource> MakeResourceAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class BlobStorageResources
    {
        public static bool TryGetResourceProviders(Azure.Storage.DataMovement.Models.DataTransferProperties info, out Azure.Storage.DataMovement.Blobs.BlobStorageResourceProvider sourceProvider, out Azure.Storage.DataMovement.Blobs.BlobStorageResourceProvider destinationProvider) { throw null; }
    }
    public partial class BlockBlobStorageResource : Azure.Storage.DataMovement.StorageResourceSingle
    {
        public BlockBlobStorageResource(Azure.Storage.Blobs.Specialized.BlockBlobClient blobClient, Azure.Storage.DataMovement.Blobs.BlockBlobStorageResourceOptions options = null) { }
        public override bool CanProduceUri { get { throw null; } }
        public override long? Length { get { throw null; } }
        public override long MaxChunkSize { get { throw null; } }
        public override string Path { get { throw null; } }
        public override string ResourceId { get { throw null; } }
        public override Azure.Storage.DataMovement.TransferType TransferType { get { throw null; } }
        public override System.Uri Uri { get { throw null; } }
        public override System.Threading.Tasks.Task CompleteTransferAsync(bool overwrite, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task CopyBlockFromUriAsync(Azure.Storage.DataMovement.StorageResourceSingle sourceResource, Azure.HttpRange range, bool overwrite, long completeLength = (long)0, Azure.Storage.DataMovement.Models.StorageResourceCopyFromUriOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task CopyFromUriAsync(Azure.Storage.DataMovement.StorageResourceSingle sourceResource, bool overwrite, long completeLength, Azure.Storage.DataMovement.Models.StorageResourceCopyFromUriOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task<bool> DeleteIfExistsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task<Azure.Storage.DataMovement.Models.StorageResourceProperties> GetPropertiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task<Azure.Storage.DataMovement.Models.ReadStreamStorageResourceResult> ReadStreamAsync(long position = (long)0, long? length = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task WriteFromStreamAsync(System.IO.Stream stream, long streamLength, bool overwrite, long position = (long)0, long completeLength = (long)0, Azure.Storage.DataMovement.Models.StorageResourceWriteToOffsetOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BlockBlobStorageResourceOptions : Azure.Storage.DataMovement.Blobs.BlobStorageResourceOptions
    {
        public BlockBlobStorageResourceOptions() { }
        public Azure.Storage.Blobs.Models.BlobRequestConditions DestinationConditions { get { throw null; } set { } }
        public Azure.Storage.Blobs.Models.BlobRequestConditions SourceConditions { get { throw null; } set { } }
    }
    public partial class PageBlobStorageResource : Azure.Storage.DataMovement.StorageResourceSingle
    {
        public PageBlobStorageResource(Azure.Storage.Blobs.Specialized.PageBlobClient blobClient, Azure.Storage.DataMovement.Blobs.PageBlobStorageResourceOptions options = null) { }
        public override bool CanProduceUri { get { throw null; } }
        public override long? Length { get { throw null; } }
        public override long MaxChunkSize { get { throw null; } }
        public override string Path { get { throw null; } }
        public override string ResourceId { get { throw null; } }
        public override Azure.Storage.DataMovement.TransferType TransferType { get { throw null; } }
        public override System.Uri Uri { get { throw null; } }
        public override System.Threading.Tasks.Task CompleteTransferAsync(bool overwrite, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task CopyBlockFromUriAsync(Azure.Storage.DataMovement.StorageResourceSingle sourceResource, Azure.HttpRange range, bool overwrite, long completeLength = (long)0, Azure.Storage.DataMovement.Models.StorageResourceCopyFromUriOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task CopyFromUriAsync(Azure.Storage.DataMovement.StorageResourceSingle sourceResource, bool overwrite, long completeLength, Azure.Storage.DataMovement.Models.StorageResourceCopyFromUriOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task<bool> DeleteIfExistsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task<Azure.Storage.DataMovement.Models.StorageResourceProperties> GetPropertiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task<Azure.Storage.DataMovement.Models.ReadStreamStorageResourceResult> ReadStreamAsync(long position = (long)0, long? length = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task WriteFromStreamAsync(System.IO.Stream stream, long streamLength, bool overwrite, long position = (long)0, long completeLength = (long)0, Azure.Storage.DataMovement.Models.StorageResourceWriteToOffsetOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class PageBlobStorageResourceOptions : Azure.Storage.DataMovement.Blobs.BlobStorageResourceOptions
    {
        public PageBlobStorageResourceOptions() { }
        public Azure.Storage.Blobs.Models.PageBlobRequestConditions DestinationConditions { get { throw null; } set { } }
        public long? SequenceNumber { get { throw null; } set { } }
        public Azure.Storage.Blobs.Models.PageBlobRequestConditions SourceConditions { get { throw null; } set { } }
    }
}
